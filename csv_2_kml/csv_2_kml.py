# csv_2_kml.py

# Open the points.csv file which contains a list of coordinates in
# (decimal format) latitude-longitude pairs. 
sourceFile = open('points.csv', 'r')

# Open the points.kml file for writing.
destinationFile = open('points.kml', 'w')

# Write the header for the KML file.
destinationFile.write('<?xml version="1.0" encoding="UTF-8"?>\n')
destinationFile.write('<kml xmlns="http://www.opengis.net/kml/2.2" xmlns:gx="http://www.google.com/kml/ext/2.2" xmlns:kml="http://www.opengis.net/kml/2.2" xmlns:atom="http://www.w3.org/2005/Atom">\n')
destinationFile.write('<Document>\n')

# Name of the destination.
destinationFile.write('<name>points.kml</name>\n')


# Counter for the number of lat-lon pairs read from the source file.
i = 0

# Read the first coordinate.
coordinates = sourceFile.readline()

# Process while there are still valid coordinates in the file.
while(coordinates != ''):
    #print (coordinates)

    # Parse the line.
    latLonCoords = [latLon.strip() for latLon in coordinates.split(',')]
    #print (latLonCoords[0])
    #print (latLonCoords[1])

    # Now write the coordinate data into the KML file.
    # Place mark
    destinationFile.write('<Placemark>\n')
    destinationFile.write('<name>My coord</name>\n')
    destinationFile.write('<Point>\n')
    destinationFile.write('<coordinates>')
    # Longitude, Latitude, Elevation
    destinationFile.write(str(latLonCoords[1]) + ',' + str(latLonCoords[0]) + ',0') 
    destinationFile.write('</coordinates>\n')
    destinationFile.write('</Point>\n')
    destinationFile.write('</Placemark>\n')

    # Read the next line.
    coordinates = sourceFile.readline()
    
    i += 1

# Display the number of coordinates read.
print (str(i) + ' coordinates read from file.')

# Close the CSV file after processing.
sourceFile.close()

# Close tags.
destinationFile.write('</Document>\n')
destinationFile.write('</kml>\n')

# Close the KML file.
destinationFile.close()
