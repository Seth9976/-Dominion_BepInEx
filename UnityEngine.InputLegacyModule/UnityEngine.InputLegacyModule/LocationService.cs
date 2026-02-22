using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public class LocationService
	{
		// Token: 0x06000092 RID: 146 RVA: 0x000023EE File Offset: 0x000005EE
		public static bool IsServiceEnabledByUser()
		{
			return LocationService.IsServiceEnabledByUserDelegateField();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000023FA File Offset: 0x000005FA
		public static LocationServiceStatus GetLocationStatus()
		{
			return LocationService.GetLocationStatusDelegateField();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002406 File Offset: 0x00000606
		public static void SetDesiredAccuracy(float value)
		{
			LocationService.SetDesiredAccuracyDelegateField(value);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002413 File Offset: 0x00000613
		public static void SetDistanceFilter(float value)
		{
			LocationService.SetDistanceFilterDelegateField(value);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002420 File Offset: 0x00000620
		public static void StartUpdatingLocation()
		{
			LocationService.StartUpdatingLocationDelegateField();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000242C File Offset: 0x0000062C
		public static void StopUpdatingLocation()
		{
			LocationService.StopUpdatingLocationDelegateField();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002438 File Offset: 0x00000638
		public static bool IsHeadingUpdatesEnabled()
		{
			return LocationService.IsHeadingUpdatesEnabledDelegateField();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002444 File Offset: 0x00000644
		public static void SetHeadingUpdatesEnabled(bool value)
		{
			LocationService.SetHeadingUpdatesEnabledDelegateField(value);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00003AC8 File Offset: 0x00001CC8
		public bool isEnabledByUser
		{
			get
			{
				return LocationService.IsServiceEnabledByUser();
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public LocationServiceStatus status
		{
			get
			{
				return LocationService.GetLocationStatus();
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002451 File Offset: 0x00000651
		public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters)
		{
			LocationService.SetDesiredAccuracy(desiredAccuracyInMeters);
			LocationService.SetDistanceFilter(updateDistanceInMeters);
			LocationService.StartUpdatingLocation();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002468 File Offset: 0x00000668
		public void Start(float desiredAccuracyInMeters)
		{
			this.Start(desiredAccuracyInMeters, 10f);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002478 File Offset: 0x00000678
		public void Start()
		{
			this.Start(10f, 10f);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000248C File Offset: 0x0000068C
		public void Stop()
		{
			LocationService.StopUpdatingLocation();
		}

		// Token: 0x04000093 RID: 147
		private static readonly LocationService.IsServiceEnabledByUserDelegate IsServiceEnabledByUserDelegateField = IL2CPP.ResolveICall<LocationService.IsServiceEnabledByUserDelegate>("UnityEngine.LocationService::IsServiceEnabledByUser");

		// Token: 0x04000094 RID: 148
		private static readonly LocationService.GetLocationStatusDelegate GetLocationStatusDelegateField = IL2CPP.ResolveICall<LocationService.GetLocationStatusDelegate>("UnityEngine.LocationService::GetLocationStatus");

		// Token: 0x04000095 RID: 149
		private static readonly LocationService.SetDesiredAccuracyDelegate SetDesiredAccuracyDelegateField = IL2CPP.ResolveICall<LocationService.SetDesiredAccuracyDelegate>("UnityEngine.LocationService::SetDesiredAccuracy");

		// Token: 0x04000096 RID: 150
		private static readonly LocationService.SetDistanceFilterDelegate SetDistanceFilterDelegateField = IL2CPP.ResolveICall<LocationService.SetDistanceFilterDelegate>("UnityEngine.LocationService::SetDistanceFilter");

		// Token: 0x04000097 RID: 151
		private static readonly LocationService.StartUpdatingLocationDelegate StartUpdatingLocationDelegateField = IL2CPP.ResolveICall<LocationService.StartUpdatingLocationDelegate>("UnityEngine.LocationService::StartUpdatingLocation");

		// Token: 0x04000098 RID: 152
		private static readonly LocationService.StopUpdatingLocationDelegate StopUpdatingLocationDelegateField = IL2CPP.ResolveICall<LocationService.StopUpdatingLocationDelegate>("UnityEngine.LocationService::StopUpdatingLocation");

		// Token: 0x04000099 RID: 153
		private static readonly LocationService.IsHeadingUpdatesEnabledDelegate IsHeadingUpdatesEnabledDelegateField = IL2CPP.ResolveICall<LocationService.IsHeadingUpdatesEnabledDelegate>("UnityEngine.LocationService::IsHeadingUpdatesEnabled");

		// Token: 0x0400009A RID: 154
		private static readonly LocationService.SetHeadingUpdatesEnabledDelegate SetHeadingUpdatesEnabledDelegateField = IL2CPP.ResolveICall<LocationService.SetHeadingUpdatesEnabledDelegate>("UnityEngine.LocationService::SetHeadingUpdatesEnabled");

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x060000FC RID: 252
		private delegate bool IsServiceEnabledByUserDelegate();

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060000FE RID: 254
		private delegate LocationServiceStatus GetLocationStatusDelegate();

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000100 RID: 256
		private delegate void SetDesiredAccuracyDelegate(float value);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000102 RID: 258
		private delegate void SetDistanceFilterDelegate(float value);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000104 RID: 260
		private delegate void StartUpdatingLocationDelegate();

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000106 RID: 262
		private delegate void StopUpdatingLocationDelegate();

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000108 RID: 264
		private delegate bool IsHeadingUpdatesEnabledDelegate();

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600010A RID: 266
		private delegate void SetHeadingUpdatesEnabledDelegate(bool value);
	}
}
