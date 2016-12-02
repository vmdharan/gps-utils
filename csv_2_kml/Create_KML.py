# Create_KML.py
# Write coordinate data into a KML file.

destinationFile = open('points.kml', 'w')

destinationFile.write('<?xml version="1.0" encoding="UTF-8"?>\n')
destinationFile.write('<kml xmlns="http://www.opengis.net/kml/2.2" xmlns:gx="http://www.google.com/kml/ext/2.2" xmlns:kml="http://www.opengis.net/kml/2.2" xmlns:atom="http://www.w3.org/2005/Atom">\n')
destinationFile.write('<Document>\n')

destinationFile.write('</Document>\n')
destinationFile.write('</kml>\n')

destinationFile.close()
