mp.events.add('tyre', (wheelId, value) => {
var localPlayer = mp.players.local;	
var vehicle = localPlayer.vehicle;
vehicle.setSuspensionHeight(value)
});