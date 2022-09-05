# Steering Behaviours
### Raymundo Giron Mosqueda

## How to use

---

    #### Target
    In a unity scene create the object that will be the target.
    ***(Important)*** Set this object's name as: ***Target***
    To this object add the Mouse_Follow.cs script as a component.
    In the inspector set the offset to 30
    

---

    #### Steerable Objects (seekers)
    Create 4 objects that will seek the target.
    To these objects add the SteeringBehaviours.cs script as a component.  
    In the inspector fill the SteeringBehaviours.cs component arguments as follows:
    - Object 0, mass: ***.5***, behaviour: ***seek***
    - Object 1, mass: ***1***, behaviour: ***seek***
    - Object 2, mass: ***1.5***, behaviour: ***seek***
    - Object 3, mass: ***2***, behaviour: ***seek***

    In the inspector set the z value of these objects's transform to: ***20.3f***
    

---

    #### Steerable Objects (fleers)
    Create 2 objects that will flee from the target.  
    To these objects add the SteeringBehaviours.cs script as a component.  
    In the inspector fill the SteeringBehaviours.cs component arguments as follows:
    - Object 1, mass: ***1***, behaviour: ***flee***
    - Object 2, mass: ***1***, behaviour: ***flee***

    In the inspector set the z value of these objects's transform to: ***20.3f***
---

## Current issues
    Clamping the object's position to remain within the screen bounds
    currently does not work. (not sure why)

