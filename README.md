
# Teaching steps

### master

```
$ react-native-create-library module-custom
```
- delete peerDependencies **react-native-windows**
- delete **windows** folder

### Step1

```
$ react-native init example
$ cd example
```
- modify example/package.json
```
"dependencies": {
    ...
    "react-native-module-custom": "file:.."
    ...
},
````

```
$ npm i
```
------------------------------------------
# react-native-module-custom

## Getting started

`$ npm install react-native-module-custom --save`

### Mostly automatic installation

`$ react-native link react-native-module-custom`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-module-custom` and add `RNModuleCustom.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNModuleCustom.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNModuleCustomPackage;` to the imports at the top of the file
  - Add `new RNModuleCustomPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-module-custom'
  	project(':react-native-module-custom').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-module-custom/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-module-custom')
  	```

## Usage
```javascript
import RNModuleCustom from 'react-native-module-custom';

// TODO: What to do with the module?
RNModuleCustom;
```
