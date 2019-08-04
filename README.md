# UIMotion
UIMotion package provides simple animations for sliding, scaling and snapping.\
Works for every UI scale mode of Canvas Scaler component, also is independent from position, anchors and pivot.

Sample project can be cloned from here, also raw package is available under releases tab.

## How To Use
Attach the scripts to any GameObject in the hierarchy and assign Canvas to the slots (for UIMotionSnap and UIMotionSlide only)

![HowTo](https://user-images.githubusercontent.com/32217921/62420858-fe109400-b6a1-11e9-9dfe-3adc41b74bdd.png)

Call static methods from wherever you desire.

AnimationCurves to manipulate motion and UnityEvents to be called after the motion can be passed as an argument to the methods.
For furher information see the Documentation pdf in the Assets folder.
