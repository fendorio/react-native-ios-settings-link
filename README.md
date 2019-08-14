
# react-native-react-native-ios-settings-link

## Getting started

`$ npm install react-native-react-native-ios-settings-link --save`

### Mostly automatic installation

`$ react-native link react-native-react-native-ios-settings-link`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-react-native-ios-settings-link` and add `RNReactNativeIosSettingsLink.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNReactNativeIosSettingsLink.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNReactNativeIosSettingsLinkPackage;` to the imports at the top of the file
  - Add `new RNReactNativeIosSettingsLinkPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-react-native-ios-settings-link'
  	project(':react-native-react-native-ios-settings-link').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-react-native-ios-settings-link/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-react-native-ios-settings-link')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNReactNativeIosSettingsLink.sln` in `node_modules/react-native-react-native-ios-settings-link/windows/RNReactNativeIosSettingsLink.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using React.Native.Ios.Settings.Link.RNReactNativeIosSettingsLink;` to the usings at the top of the file
  - Add `new RNReactNativeIosSettingsLinkPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNReactNativeIosSettingsLink from 'react-native-react-native-ios-settings-link';

// TODO: What to do with the module?
RNReactNativeIosSettingsLink;
```
  