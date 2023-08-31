# ZSSN (Zombie Survival Social Network)

##Endpoints

###[Get] api/survivor 
-Fetches all survivors, displaying id, name, age, gender and last location

###[Post] api/survivor
-Add a survivor by defining the following model in the request body:
```json
{
	"name": "John",
	"age": 20,
	"gender": "Male",
	"lastLocation": {
		latitude: -10.001,
		longitude: 30.323
	}
}
```

###[Post] api/survivor/:id/infected
-Flag a  survivor as infected. Use the survivor id from the [Get] survivor endpoint here to flag the specific survivor.

###[Put] api/survivor/:id/location
-Update the last location of a survivor by id. Use the following model in the request body:
```json
{
  "latitude": 90,
  "longitude": 180
}
```