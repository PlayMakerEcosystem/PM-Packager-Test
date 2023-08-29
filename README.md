# PlayMaker Ecosystem Upm packaging test


This is a test for publishing to Unity Packager



 # Installation 
When your package is distributed, you can install it into any Unity project. 

* Open Unity Project Settings Window
* Select the Package Manager section
* Add a new Scoped Registries
	- Name "hutongGames"
	-  URL "https://registry.npmjs.org"
	-  Scope "com.playmaker.ecosystem"


* Close Unity Project Settings Window

* Open Unity Packager Window
	* Click on the "+" drop down and select "Add Package By Name"
	* use "com.playmaker.ecosystem.upm.test" as the name of the package
	* Click "Add"

* The package is now installed	




