using IObserver;

LocationTracker provider = new LocationTracker();
LocationReporter reporter1 = new LocationReporter("FixedGPS");
LocationReporter reporter2 = new LocationReporter("MobileGPS");

// Выполняем подписку 
reporter1.Subscribe(provider);
reporter2.Subscribe(provider);

provider.TrackLocation(new Location(47.6456, -122.1312));
reporter1.Unsubscribe();
provider.TrackLocation(new Location(47.6677, -122.1199));
provider.TrackLocation(null);
provider.EndTransmission();