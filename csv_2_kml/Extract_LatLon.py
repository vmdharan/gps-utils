# Extract_LatLon.py
# Read the points.csv file which contains a list of coordinates in
# (decimal format) latitude-longitude pairs. 

sourceFile = open('points.csv', 'r')

i = 0
coordinates = sourceFile.readline()

while(coordinates != ''):
    print (coordinates)

    latLonCoords = [latLon.strip() for latLon in coordinates.split(',')]
    print (latLonCoords[0])
    print (latLonCoords[1])

    coordinates = sourceFile.readline()
    
    i += 1

print (str(i) + ' coordinates read from file.')

sourceFile.close()


