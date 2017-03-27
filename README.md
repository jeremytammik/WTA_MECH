# WTA_MECH

![RibbonTab](/MechRibbonTab.PNG)

Revit Add-in in c# &mdash; Creates a custom ribbon Tab with discipline related tools. The tools at this writing are for placing specific Revit family types with some families requiring parameter settings made on the fly.

This repository is provided for sharing and learning purposes. Perhaps someone might provide improvements or education. Perhaps it will help to boost someone further up the steep learning curve needed to create Revit task add-ins. Hopefully it does not show too much of the wrong way.  

Used by the tools in this ribbon are classes intended to provide a Revit family instance placement without the Revit user interface overhead normally required by Revit. The classes are intended to provide a universal mechanism for placing some types of Revit families. This includes tags, which is a task not in this discipline tab but is in other discipline add-ins. The custom tab employs menu methods not commonly explained, for example a split button sets a family placement mode that is exposed to the functions called by command picks. Other tools use add-in application settings as a way to persist settings or communicate to code that runs subsequently within a command that provides a task workflow.

This add-in demonstrates many of the typical tasks and implementation required for providing a tab menu interface involving family placement, e.g.:

* Creating a ribbon tab populated with some controls
  - Tool tips
  - Image file to button image
  - Communication between controls and commands the controls execute
* Establishing the family type for placement
  - Determine if the correct pairing exists in the current file
  - Automatically discovering and loading the family if it does not exist in the current file but does exist somewhere starting from some set directory
* Providing the family type placement interface
  - In multiple mode or one shot mode
  - With a heads-up status/instruction interface form
    - As WPF with independent behavior
      - Sending focus back to the Revit view
  - Returning the family instance placement for further processing after the instance has been placed
  - Managing an escape out from the process
  - Handling correct view type context
* Changing family parameter values

Much of the code is by others. Its mangling and ignorant misuse is my ongoing doing. Much thanks to the professionals like Jeremy Tammik who provided the means directly or by mention one way or another for probably all the code needed.

## Specific Interest

**Hybrid splitbutton behavior** &mdash; A splitbutton control having four buttons where the top two buttons execute one of two types of the same task and the bottom two buttons invoke a settings panel for one of the corresponding task types. The top two buttons, being tasks the user is likely going to repeat, remain as the last button selected. The bottom two buttons are incidental tasks the user would not need to repeat nor want to be the splitbutton's face button. The splitbutton face button reverts back to what is was before the user has selected one of the bottom two button. That is the hybrid behavior. This idea was discussed here: [thebuildingcoder - stacked-ribbon-button-panel-options][dba09e78]

  [dba09e78]: http://thebuildingcoder.typepad.com/blog/2016/09/stacked-ribbon-button-panel-options.html "thebuildingcoder - stacked-ribbon-button-panel-options"

**Host face normal direction used to drive symbology orientation** &mdash; The HVAC sensor family placed by the tools has two symbology orientations in the family because Revit does not really support a universal "view independent text". The family's symbology would be wrong 50% of the time it were placed. The code attempts to use the host face normal direction to more correctly pick which of the two orientations to make visible. Each orientation's visibility is controlled by a parameter. Only one parameter is needed to be set because the other parameter is function controlled in the family to be not(the_other).

**User settings for family names, types and tag parameter names** &mdash; As a way to side step the problem of hard coding family names, types and tag parameter names the user can set the names to some other values. Not implemented, but intended, is for an external file text to also house the standard settings.

**Remote equipment tag** &mdash; Sensors, like thermostats for example, are often the client to a piece of a mechanical system. The mechanical system's name the sensor is a client for, an ID number for example, is typically placed next to the sensor on construction plans. That ID number is part of the mechanical equipment's properties but not the sensor's properties unless it where duplicated to the sensor. Therefore tagging the sensor using the latter method involves more effort and maintenance. The remote equipment tag is a tag to the mechanical equipment but placed at the sensor. That is what this add-in is doing. It would be nice if Revit were to support an indirect tag value much like the way a microprocessor does indirect addressing. Then the sensor could be tagged with a tag that gets its values from the parameter values of an indirectly addressed object.

**Multiple view annotation placement** &mdash; This add-in can place the annotations, the tags, simultaneously in more than one view at a time. The tag final placement code iterates through a list of candidate views when it places the tag. That list is developed by a single function using specific rules, which one would have to devise to their needs, that operate on parent view names. For example if the active view is a dependent view then its parent view name is used in the candidate logic. The reason for this feature is due to one of Revit's worst usability problems where annotation is relegated to the output composition task and not visible during the more important design and engineering tasks.         
