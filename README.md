# generator-isobar
> Yeoman generator for Sitecore Projects 

## Installation

First, install [Yeoman](http://yeoman.io) and generator-isobar using [npm](https://www.npmjs.com/) (we assume you have pre-installed [node.js](https://nodejs.org/)).

```bash
npm install -g yo
npm install -g generator-isobar
```

## What is it?
The purpose of generator-isobar is to reduce the time when creating Sitecore projects following [Helix] guidelines

## Project
Execute the following command in an empty folder
```bash
yo generator-isobar
```
It will create the initial scaffolding to start Sitecore-ing following Helix

## Adding Features

Execute in the root of your existing Sitecore source code:

```bash
yo generator-isobar:feature
```
...then configure your project based on yeoman questions.


## Adding TDS projects to existing Features

Execute in the root of your existing Sitecore source code:

```bash
yo generator-isobar:feature-tds
```
Yeoman will ask you the information of the existing project (Solution Name, Feature Name), Sitecore database and the new TDS project alias/name you want to use. The new TDS project will be named like: ```SolutionName.Feature.FeatureName.Alias ```

## Adding Foundation Modules

Execute in the root of your existing Sitecore source code:

```bash
yo generator-isobar:foundation
```
...then configure your project based on yeoman questions.

## Adding TDS projects to existing Foundation

Execute in the root of your existing Sitecore source code:

```bash
yo generator-isobar:foundation-tds
```
Yeoman will ask you the information of the existing project (Solution Name, Foundation Name), Sitecore database and the new TDS project alias/name you want to use. The new TDS project will be named like: ```SolutionName.Foundation.FoundationName.Alias ```


## Background

This generator is based on [kamsar] yeoman [habitat generator] but this implementation is not tied to habitat project and has some extra features such as:

* Allows to create new Sitecore projects following [Helix] guidelines from scratch.
* Allows to create TDS projects. 
* Allows dynamic solution names.
* Allows to select different .NET Frameworks .  


[kamsar]: https://twitter.com/kamsar
[habitat generator]: https://github.com/kamsar/generator-habitat/
[Helix]: http://helix.sitecore.net/

