# Trainge Prototype

A prototype of an e-learning platform for Chainge called Trainged (combination of words Traing + Chainge).

## Requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 5.0.0 or higher
* [node.js](https://nodejs.org) 16.0.0 or higher

## Development

Before doing anything, start with installing npm dependencies using `npm install`.

Then to start development mode with hot module reloading, run:
```bash
npm start
```
This will start the development server after compiling the project, once it is finished, navigate to http://localhost:8080 to view the application .

To build the application and make ready for production:
```
npm run build
```
This command builds the application and puts the generated files into the `deploy` directory (can be overwritten in webpack.config.js).

### Tests

The template includes a test project that ready to go which you can either run in the browser in watch mode or run in the console using node.js and mocha. To run the tests in watch mode:
```
npm run test:live
```
This command starts a development server for the test application and makes it available at http://localhost:8085.

To run the tests using the command line and of course in your CI server, you have to use the mocha test runner which doesn't use the browser but instead runs the code using node.js:
```
npm test
```

# Technical Implementation of The Trainge Protype

The Trainge prototype is built as a web application written in a functional style using F#, as F# offer many language features that prevent program errors compared to other languages such as Javascript or Typescript. Using the Fable F# to Javascript compiler, the prototype is then able to be run as a web application in the browser. The F# code robustness is transitively applied to the resulting compiled Javascript when using Fable.

Several large frameworks are used to realise the prototype, mainly the React and Bulma frameworks which is used to define the structure, look and reactivity of the prototype. Reactivity is important, as it allows the UI to become driven by data instead of imperatively/manually updating relevant UI components when the underlying data changes. This is automatically afforded to us using React. As React is not a native framework to the F# language an auxiliary library called Feliz is used to interface F# to the Javascript-based React framework.

To structure the code we are using the Elm Architecture (TEA). TEA is a way to split an application into smaller applications or components that are easily composed together without introducing unnecessary coupling between said components. Essentially, it is a way to control 'spaghetti' code and make sure that error inducing changes in one part of the prototype does affect another part of the prototype. This is strictly not necessary for a small prototype as Trainge, but hugely useful in the case Chainge needs to scale up the prototype to a fully fledged application.
