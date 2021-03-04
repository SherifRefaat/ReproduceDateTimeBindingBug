# ReproduceDateTimeBindingBug
 
This repository is to reproduce the bug in `DateTime` binding when using `FromQuery` & `FromForm`.
The model binder doesn't respect the `DateTimeFormatInfo` when the binding is coming from `FromQuery` source.
