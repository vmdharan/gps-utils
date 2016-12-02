# Create_KML.py
# Write coordinate data into a KML file.

destinationFile = open('points.kml', 'w')

latCoord1 = -32.54321
lonCoord1 = 133.12345
latCoord2 = -32.54322
lonCoord2 = 133.22345
latCoord3 = -32.54323
lonCoord3 = 133.32345

# Basic header
destinationFile.write('<?xml version="1.0" encoding="UTF-8"?>\n')
destinationFile.write('<kml xmlns="http://www.opengis.net/kml/2.2" xmlns:gx="http://www.google.com/kml/ext/2.2" xmlns:kml="http://www.opengis.net/kml/2.2" xmlns:atom="http://www.w3.org/2005/Atom">\n')
destinationFile.write('<Document>\n')

# Name
destinationFile.write('<name>points.kml</name>\n')

# Place mark
destinationFile.write('<Placemark>\n')
destinationFile.write('<name>My coord</name>\n')
destinationFile.write('<Point>\n')
destinationFile.write('<coordinates>')
destinationFile.write(str(lonCoord1) + ',' + str(latCoord1) + ',0') 
destinationFile.write('</coordinates>\n')
destinationFile.write('</Point>\n')
destinationFile.write('</Placemark>\n')

destinationFile.write('<Placemark>\n')
destinationFile.write('<name>My coord</name>\n')
destinationFile.write('<Point>\n')
destinationFile.write('<coordinates>')
destinationFile.write(str(lonCoord2) + ',' + str(latCoord2) + ',0') 
destinationFile.write('</coordinates>\n')
destinationFile.write('</Point>\n')
destinationFile.write('</Placemark>\n')

destinationFile.write('<Placemark>\n')
destinationFile.write('<name>My coord</name>\n')
destinationFile.write('<Point>\n')
destinationFile.write('<coordinates>')
destinationFile.write(str(lonCoord3) + ',' + str(latCoord3) + ',0') 
destinationFile.write('</coordinates>\n')
destinationFile.write('</Point>\n')
destinationFile.write('</Placemark>\n')

# Close tags
destinationFile.write('</Document>\n')
destinationFile.write('</kml>\n')

destinationFile.close()
