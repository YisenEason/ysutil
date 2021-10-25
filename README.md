
# react-native-ysutil

## Getting started

`$ npm install react-native-ysutil --save`

### Mostly automatic installation

`$ react-native link react-native-ysutil`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-ysutil` and add `RNYsutil.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNYsutil.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNYsutilPackage;` to the imports at the top of the file
  - Add `new RNYsutilPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-ysutil'
  	project(':react-native-ysutil').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-ysutil/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-ysutil')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNYsutil.sln` in `node_modules/react-native-ysutil/windows/RNYsutil.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Ysutil.RNYsutil;` to the usings at the top of the file
  - Add `new RNYsutilPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNYsutil from 'react-native-ysutil';

// TODO: What to do with the module?
RNYsutil;
```
  