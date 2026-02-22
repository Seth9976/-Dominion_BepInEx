using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x02000337 RID: 823
	public sealed class Activity : Object
	{
		// Token: 0x06003096 RID: 12438 RVA: 0x000CE2B4 File Offset: 0x000CC4B4
		// Note: this type is marked as 'beforefieldinit'.
		static Activity()
		{
			Il2CppClassPointerStore<Activity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "Activity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Activity>.NativeClassPtr);
			Activity.NativeFieldInfoPtr_AEROBICS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "AEROBICS");
			Activity.NativeFieldInfoPtr_ARCHERY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ARCHERY");
			Activity.NativeFieldInfoPtr_BADMINTON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BADMINTON");
			Activity.NativeFieldInfoPtr_BASEBALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BASEBALL");
			Activity.NativeFieldInfoPtr_BASKETBALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BASKETBALL");
			Activity.NativeFieldInfoPtr_BIATHLON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BIATHLON");
			Activity.NativeFieldInfoPtr_BIKING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BIKING");
			Activity.NativeFieldInfoPtr_BIKING_HAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BIKING_HAND");
			Activity.NativeFieldInfoPtr_BIKING_MOUNTAIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BIKING_MOUNTAIN");
			Activity.NativeFieldInfoPtr_BIKING_ROAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BIKING_ROAD");
			Activity.NativeFieldInfoPtr_BIKING_SPINNING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BIKING_SPINNING");
			Activity.NativeFieldInfoPtr_BIKING_STATIONARY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BIKING_STATIONARY");
			Activity.NativeFieldInfoPtr_BIKING_UTILITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BIKING_UTILITY");
			Activity.NativeFieldInfoPtr_BOXING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "BOXING");
			Activity.NativeFieldInfoPtr_CALISTHENICS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "CALISTHENICS");
			Activity.NativeFieldInfoPtr_CIRCUIT_TRAINING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "CIRCUIT_TRAINING");
			Activity.NativeFieldInfoPtr_CRICKET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "CRICKET");
			Activity.NativeFieldInfoPtr_CROSSFIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "CROSSFIT");
			Activity.NativeFieldInfoPtr_CURLING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "CURLING");
			Activity.NativeFieldInfoPtr_DANCING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "DANCING");
			Activity.NativeFieldInfoPtr_DIVING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "DIVING");
			Activity.NativeFieldInfoPtr_ELEVATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ELEVATOR");
			Activity.NativeFieldInfoPtr_ELLIPTICAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ELLIPTICAL");
			Activity.NativeFieldInfoPtr_ERGOMETER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ERGOMETER");
			Activity.NativeFieldInfoPtr_ESCALATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ESCALATOR");
			Activity.NativeFieldInfoPtr_FENCING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "FENCING");
			Activity.NativeFieldInfoPtr_FOOTBALL_AMERICAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "FOOTBALL_AMERICAN");
			Activity.NativeFieldInfoPtr_FOOTBALL_AUSTRALIAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "FOOTBALL_AUSTRALIAN");
			Activity.NativeFieldInfoPtr_FOOTBALL_SOCCER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "FOOTBALL_SOCCER");
			Activity.NativeFieldInfoPtr_FRISBEE_DISC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "FRISBEE_DISC");
			Activity.NativeFieldInfoPtr_GARDENING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "GARDENING");
			Activity.NativeFieldInfoPtr_GOLF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "GOLF");
			Activity.NativeFieldInfoPtr_GYMNASTICS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "GYMNASTICS");
			Activity.NativeFieldInfoPtr_HANDBALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "HANDBALL");
			Activity.NativeFieldInfoPtr_HIGH_INTENSITY_INTERVAL_TRAINING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "HIGH_INTENSITY_INTERVAL_TRAINING");
			Activity.NativeFieldInfoPtr_HIKING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "HIKING");
			Activity.NativeFieldInfoPtr_HOCKEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "HOCKEY");
			Activity.NativeFieldInfoPtr_HORSEBACK_RIDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "HORSEBACK_RIDING");
			Activity.NativeFieldInfoPtr_HOUSEWORK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "HOUSEWORK");
			Activity.NativeFieldInfoPtr_ICE_SKATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ICE_SKATING");
			Activity.NativeFieldInfoPtr_IN_VEHICLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "IN_VEHICLE");
			Activity.NativeFieldInfoPtr_INTERVAL_TRAINING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "INTERVAL_TRAINING");
			Activity.NativeFieldInfoPtr_JUMP_ROPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "JUMP_ROPE");
			Activity.NativeFieldInfoPtr_KAYAKING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "KAYAKING");
			Activity.NativeFieldInfoPtr_KETTLEBELL_TRAINING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "KETTLEBELL_TRAINING");
			Activity.NativeFieldInfoPtr_KICK_SCOOTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "KICK_SCOOTER");
			Activity.NativeFieldInfoPtr_KICKBOXING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "KICKBOXING");
			Activity.NativeFieldInfoPtr_KITESURFING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "KITESURFING");
			Activity.NativeFieldInfoPtr_MARTIAL_ARTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "MARTIAL_ARTS");
			Activity.NativeFieldInfoPtr_MEDITATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "MEDITATION");
			Activity.NativeFieldInfoPtr_MIXED_MARTIAL_ARTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "MIXED_MARTIAL_ARTS");
			Activity.NativeFieldInfoPtr_ON_FOOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ON_FOOT");
			Activity.NativeFieldInfoPtr_OTHER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "OTHER");
			Activity.NativeFieldInfoPtr_P90X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "P90X");
			Activity.NativeFieldInfoPtr_PARAGLIDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "PARAGLIDING");
			Activity.NativeFieldInfoPtr_PILATES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "PILATES");
			Activity.NativeFieldInfoPtr_POLO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "POLO");
			Activity.NativeFieldInfoPtr_RACQUETBALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "RACQUETBALL");
			Activity.NativeFieldInfoPtr_ROCK_CLIMBING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ROCK_CLIMBING");
			Activity.NativeFieldInfoPtr_ROWING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ROWING");
			Activity.NativeFieldInfoPtr_ROWING_MACHINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ROWING_MACHINE");
			Activity.NativeFieldInfoPtr_RUGBY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "RUGBY");
			Activity.NativeFieldInfoPtr_RUNNING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "RUNNING");
			Activity.NativeFieldInfoPtr_RUNNING_JOGGING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "RUNNING_JOGGING");
			Activity.NativeFieldInfoPtr_RUNNING_SAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "RUNNING_SAND");
			Activity.NativeFieldInfoPtr_RUNNING_TREADMILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "RUNNING_TREADMILL");
			Activity.NativeFieldInfoPtr_SAILING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SAILING");
			Activity.NativeFieldInfoPtr_SCUBA_DIVING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SCUBA_DIVING");
			Activity.NativeFieldInfoPtr_SKATEBOARDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKATEBOARDING");
			Activity.NativeFieldInfoPtr_SKATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKATING");
			Activity.NativeFieldInfoPtr_SKATING_CROSS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKATING_CROSS");
			Activity.NativeFieldInfoPtr_SKATING_INDOOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKATING_INDOOR");
			Activity.NativeFieldInfoPtr_SKATING_INLINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKATING_INLINE");
			Activity.NativeFieldInfoPtr_SKIING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKIING");
			Activity.NativeFieldInfoPtr_SKIING_BACK_COUNTRY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKIING_BACK_COUNTRY");
			Activity.NativeFieldInfoPtr_SKIING_CROSS_COUNTRY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKIING_CROSS_COUNTRY");
			Activity.NativeFieldInfoPtr_SKIING_DOWNHILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKIING_DOWNHILL");
			Activity.NativeFieldInfoPtr_SKIING_KITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKIING_KITE");
			Activity.NativeFieldInfoPtr_SKIING_ROLLER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SKIING_ROLLER");
			Activity.NativeFieldInfoPtr_SLEDDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SLEDDING");
			Activity.NativeFieldInfoPtr_SLEEP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SLEEP");
			Activity.NativeFieldInfoPtr_SLEEP_LIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SLEEP_LIGHT");
			Activity.NativeFieldInfoPtr_SLEEP_DEEP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SLEEP_DEEP");
			Activity.NativeFieldInfoPtr_SLEEP_REM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SLEEP_REM");
			Activity.NativeFieldInfoPtr_SLEEP_AWAKE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SLEEP_AWAKE");
			Activity.NativeFieldInfoPtr_SNOWBOARDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SNOWBOARDING");
			Activity.NativeFieldInfoPtr_SNOWMOBILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SNOWMOBILE");
			Activity.NativeFieldInfoPtr_SNOWSHOEING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SNOWSHOEING");
			Activity.NativeFieldInfoPtr_SQUASH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SQUASH");
			Activity.NativeFieldInfoPtr_STAIR_CLIMBING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "STAIR_CLIMBING");
			Activity.NativeFieldInfoPtr_STAIR_CLIMBING_MACHINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "STAIR_CLIMBING_MACHINE");
			Activity.NativeFieldInfoPtr_STANDUP_PADDLEBOARDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "STANDUP_PADDLEBOARDING");
			Activity.NativeFieldInfoPtr_STILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "STILL");
			Activity.NativeFieldInfoPtr_STRENGTH_TRAINING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "STRENGTH_TRAINING");
			Activity.NativeFieldInfoPtr_SURFING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SURFING");
			Activity.NativeFieldInfoPtr_SWIMMING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SWIMMING");
			Activity.NativeFieldInfoPtr_SWIMMING_POOL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SWIMMING_POOL");
			Activity.NativeFieldInfoPtr_SWIMMING_OPEN_WATER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "SWIMMING_OPEN_WATER");
			Activity.NativeFieldInfoPtr_TABLE_TENNIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "TABLE_TENNIS");
			Activity.NativeFieldInfoPtr_TEAM_SPORTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "TEAM_SPORTS");
			Activity.NativeFieldInfoPtr_TENNIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "TENNIS");
			Activity.NativeFieldInfoPtr_TILTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "TILTING");
			Activity.NativeFieldInfoPtr_TREADMILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "TREADMILL");
			Activity.NativeFieldInfoPtr_UNKNOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "UNKNOWN");
			Activity.NativeFieldInfoPtr_VOLLEYBALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "VOLLEYBALL");
			Activity.NativeFieldInfoPtr_VOLLEYBALL_BEACH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "VOLLEYBALL_BEACH");
			Activity.NativeFieldInfoPtr_VOLLEYBALL_INDOOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "VOLLEYBALL_INDOOR");
			Activity.NativeFieldInfoPtr_WAKEBOARDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "WAKEBOARDING");
			Activity.NativeFieldInfoPtr_WALKING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "WALKING");
			Activity.NativeFieldInfoPtr_WALKING_FITNESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "WALKING_FITNESS");
			Activity.NativeFieldInfoPtr_WALKING_NORDIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "WALKING_NORDIC");
			Activity.NativeFieldInfoPtr_WALKING_TREADMILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "WALKING_TREADMILL");
			Activity.NativeFieldInfoPtr_WALKING_STROLLER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "WALKING_STROLLER");
			Activity.NativeFieldInfoPtr_WATER_POLO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "WATER_POLO");
			Activity.NativeFieldInfoPtr_WEIGHTLIFTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "WEIGHTLIFTING");
			Activity.NativeFieldInfoPtr_WHEELCHAIR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "WHEELCHAIR");
			Activity.NativeFieldInfoPtr_WINDSURFING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "WINDSURFING");
			Activity.NativeFieldInfoPtr_YOGA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "YOGA");
			Activity.NativeFieldInfoPtr_ZUMBA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "ZUMBA");
			Activity.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Activity>.NativeClassPtr, "value");
			Activity.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activity>.NativeClassPtr, 100669683);
			Activity.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activity>.NativeClassPtr, 100669684);
			Activity.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activity>.NativeClassPtr, 100669685);
			Activity.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activity>.NativeClassPtr, 100669686);
			Activity.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Activity>.NativeClassPtr, 100669687);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x000CECA8 File Offset: 0x000CCEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221636, XrefRangeEnd = 221639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Activity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Activity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activity.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x000CECE4 File Offset: 0x000CCEE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221642, RefRangeEnd = 221644, XrefRangeStart = 221639, XrefRangeEnd = 221642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Activity(string alias)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Activity>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(alias);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activity.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x000CED30 File Offset: 0x000CCF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221644, XrefRangeEnd = 221653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activity.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x000CED80 File Offset: 0x000CCF80
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221576, XrefRangeStart = 221564, XrefRangeEnd = 221576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activity.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x000CEDBC File Offset: 0x000CCFBC
		public unsafe string Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Activity.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x00012A07 File Offset: 0x00010C07
		public Activity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x000CEDF4 File Offset: 0x000CCFF4
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x00012A10 File Offset: 0x00010C10
		public unsafe static Activity AEROBICS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_AEROBICS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_AEROBICS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x000CEE1C File Offset: 0x000CD01C
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x00012A22 File Offset: 0x00010C22
		public unsafe static Activity ARCHERY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ARCHERY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ARCHERY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x000CEE44 File Offset: 0x000CD044
		// (set) Token: 0x060030A2 RID: 12450 RVA: 0x00012A34 File Offset: 0x00010C34
		public unsafe static Activity BADMINTON
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BADMINTON, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BADMINTON, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x000CEE6C File Offset: 0x000CD06C
		// (set) Token: 0x060030A4 RID: 12452 RVA: 0x00012A46 File Offset: 0x00010C46
		public unsafe static Activity BASEBALL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BASEBALL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BASEBALL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x000CEE94 File Offset: 0x000CD094
		// (set) Token: 0x060030A6 RID: 12454 RVA: 0x00012A58 File Offset: 0x00010C58
		public unsafe static Activity BASKETBALL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BASKETBALL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BASKETBALL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060030A7 RID: 12455 RVA: 0x000CEEBC File Offset: 0x000CD0BC
		// (set) Token: 0x060030A8 RID: 12456 RVA: 0x00012A6A File Offset: 0x00010C6A
		public unsafe static Activity BIATHLON
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BIATHLON, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BIATHLON, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x000CEEE4 File Offset: 0x000CD0E4
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x00012A7C File Offset: 0x00010C7C
		public unsafe static Activity BIKING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BIKING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BIKING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x000CEF0C File Offset: 0x000CD10C
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x00012A8E File Offset: 0x00010C8E
		public unsafe static Activity BIKING_HAND
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BIKING_HAND, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BIKING_HAND, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x000CEF34 File Offset: 0x000CD134
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x00012AA0 File Offset: 0x00010CA0
		public unsafe static Activity BIKING_MOUNTAIN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BIKING_MOUNTAIN, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BIKING_MOUNTAIN, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x000CEF5C File Offset: 0x000CD15C
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x00012AB2 File Offset: 0x00010CB2
		public unsafe static Activity BIKING_ROAD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BIKING_ROAD, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BIKING_ROAD, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x000CEF84 File Offset: 0x000CD184
		// (set) Token: 0x060030B2 RID: 12466 RVA: 0x00012AC4 File Offset: 0x00010CC4
		public unsafe static Activity BIKING_SPINNING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BIKING_SPINNING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BIKING_SPINNING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x000CEFAC File Offset: 0x000CD1AC
		// (set) Token: 0x060030B4 RID: 12468 RVA: 0x00012AD6 File Offset: 0x00010CD6
		public unsafe static Activity BIKING_STATIONARY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BIKING_STATIONARY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BIKING_STATIONARY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060030B5 RID: 12469 RVA: 0x000CEFD4 File Offset: 0x000CD1D4
		// (set) Token: 0x060030B6 RID: 12470 RVA: 0x00012AE8 File Offset: 0x00010CE8
		public unsafe static Activity BIKING_UTILITY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BIKING_UTILITY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BIKING_UTILITY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060030B7 RID: 12471 RVA: 0x000CEFFC File Offset: 0x000CD1FC
		// (set) Token: 0x060030B8 RID: 12472 RVA: 0x00012AFA File Offset: 0x00010CFA
		public unsafe static Activity BOXING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_BOXING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_BOXING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x000CF024 File Offset: 0x000CD224
		// (set) Token: 0x060030BA RID: 12474 RVA: 0x00012B0C File Offset: 0x00010D0C
		public unsafe static Activity CALISTHENICS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_CALISTHENICS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_CALISTHENICS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x000CF04C File Offset: 0x000CD24C
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x00012B1E File Offset: 0x00010D1E
		public unsafe static Activity CIRCUIT_TRAINING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_CIRCUIT_TRAINING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_CIRCUIT_TRAINING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x000CF074 File Offset: 0x000CD274
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x00012B30 File Offset: 0x00010D30
		public unsafe static Activity CRICKET
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_CRICKET, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_CRICKET, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x000CF09C File Offset: 0x000CD29C
		// (set) Token: 0x060030C0 RID: 12480 RVA: 0x00012B42 File Offset: 0x00010D42
		public unsafe static Activity CROSSFIT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_CROSSFIT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_CROSSFIT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x000CF0C4 File Offset: 0x000CD2C4
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x00012B54 File Offset: 0x00010D54
		public unsafe static Activity CURLING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_CURLING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_CURLING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000CF0EC File Offset: 0x000CD2EC
		// (set) Token: 0x060030C4 RID: 12484 RVA: 0x00012B66 File Offset: 0x00010D66
		public unsafe static Activity DANCING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_DANCING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_DANCING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x000CF114 File Offset: 0x000CD314
		// (set) Token: 0x060030C6 RID: 12486 RVA: 0x00012B78 File Offset: 0x00010D78
		public unsafe static Activity DIVING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_DIVING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_DIVING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x000CF13C File Offset: 0x000CD33C
		// (set) Token: 0x060030C8 RID: 12488 RVA: 0x00012B8A File Offset: 0x00010D8A
		public unsafe static Activity ELEVATOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ELEVATOR, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ELEVATOR, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060030C9 RID: 12489 RVA: 0x000CF164 File Offset: 0x000CD364
		// (set) Token: 0x060030CA RID: 12490 RVA: 0x00012B9C File Offset: 0x00010D9C
		public unsafe static Activity ELLIPTICAL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ELLIPTICAL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ELLIPTICAL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x000CF18C File Offset: 0x000CD38C
		// (set) Token: 0x060030CC RID: 12492 RVA: 0x00012BAE File Offset: 0x00010DAE
		public unsafe static Activity ERGOMETER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ERGOMETER, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ERGOMETER, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060030CD RID: 12493 RVA: 0x000CF1B4 File Offset: 0x000CD3B4
		// (set) Token: 0x060030CE RID: 12494 RVA: 0x00012BC0 File Offset: 0x00010DC0
		public unsafe static Activity ESCALATOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ESCALATOR, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ESCALATOR, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060030CF RID: 12495 RVA: 0x000CF1DC File Offset: 0x000CD3DC
		// (set) Token: 0x060030D0 RID: 12496 RVA: 0x00012BD2 File Offset: 0x00010DD2
		public unsafe static Activity FENCING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_FENCING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_FENCING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x000CF204 File Offset: 0x000CD404
		// (set) Token: 0x060030D2 RID: 12498 RVA: 0x00012BE4 File Offset: 0x00010DE4
		public unsafe static Activity FOOTBALL_AMERICAN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_FOOTBALL_AMERICAN, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_FOOTBALL_AMERICAN, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060030D3 RID: 12499 RVA: 0x000CF22C File Offset: 0x000CD42C
		// (set) Token: 0x060030D4 RID: 12500 RVA: 0x00012BF6 File Offset: 0x00010DF6
		public unsafe static Activity FOOTBALL_AUSTRALIAN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_FOOTBALL_AUSTRALIAN, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_FOOTBALL_AUSTRALIAN, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060030D5 RID: 12501 RVA: 0x000CF254 File Offset: 0x000CD454
		// (set) Token: 0x060030D6 RID: 12502 RVA: 0x00012C08 File Offset: 0x00010E08
		public unsafe static Activity FOOTBALL_SOCCER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_FOOTBALL_SOCCER, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_FOOTBALL_SOCCER, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060030D7 RID: 12503 RVA: 0x000CF27C File Offset: 0x000CD47C
		// (set) Token: 0x060030D8 RID: 12504 RVA: 0x00012C1A File Offset: 0x00010E1A
		public unsafe static Activity FRISBEE_DISC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_FRISBEE_DISC, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_FRISBEE_DISC, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x000CF2A4 File Offset: 0x000CD4A4
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x00012C2C File Offset: 0x00010E2C
		public unsafe static Activity GARDENING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_GARDENING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_GARDENING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x000CF2CC File Offset: 0x000CD4CC
		// (set) Token: 0x060030DC RID: 12508 RVA: 0x00012C3E File Offset: 0x00010E3E
		public unsafe static Activity GOLF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_GOLF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_GOLF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x000CF2F4 File Offset: 0x000CD4F4
		// (set) Token: 0x060030DE RID: 12510 RVA: 0x00012C50 File Offset: 0x00010E50
		public unsafe static Activity GYMNASTICS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_GYMNASTICS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_GYMNASTICS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x000CF31C File Offset: 0x000CD51C
		// (set) Token: 0x060030E0 RID: 12512 RVA: 0x00012C62 File Offset: 0x00010E62
		public unsafe static Activity HANDBALL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_HANDBALL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_HANDBALL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x000CF344 File Offset: 0x000CD544
		// (set) Token: 0x060030E2 RID: 12514 RVA: 0x00012C74 File Offset: 0x00010E74
		public unsafe static Activity HIGH_INTENSITY_INTERVAL_TRAINING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_HIGH_INTENSITY_INTERVAL_TRAINING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_HIGH_INTENSITY_INTERVAL_TRAINING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060030E3 RID: 12515 RVA: 0x000CF36C File Offset: 0x000CD56C
		// (set) Token: 0x060030E4 RID: 12516 RVA: 0x00012C86 File Offset: 0x00010E86
		public unsafe static Activity HIKING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_HIKING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_HIKING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060030E5 RID: 12517 RVA: 0x000CF394 File Offset: 0x000CD594
		// (set) Token: 0x060030E6 RID: 12518 RVA: 0x00012C98 File Offset: 0x00010E98
		public unsafe static Activity HOCKEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_HOCKEY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_HOCKEY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060030E7 RID: 12519 RVA: 0x000CF3BC File Offset: 0x000CD5BC
		// (set) Token: 0x060030E8 RID: 12520 RVA: 0x00012CAA File Offset: 0x00010EAA
		public unsafe static Activity HORSEBACK_RIDING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_HORSEBACK_RIDING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_HORSEBACK_RIDING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060030E9 RID: 12521 RVA: 0x000CF3E4 File Offset: 0x000CD5E4
		// (set) Token: 0x060030EA RID: 12522 RVA: 0x00012CBC File Offset: 0x00010EBC
		public unsafe static Activity HOUSEWORK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_HOUSEWORK, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_HOUSEWORK, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x000CF40C File Offset: 0x000CD60C
		// (set) Token: 0x060030EC RID: 12524 RVA: 0x00012CCE File Offset: 0x00010ECE
		public unsafe static Activity ICE_SKATING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ICE_SKATING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ICE_SKATING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x000CF434 File Offset: 0x000CD634
		// (set) Token: 0x060030EE RID: 12526 RVA: 0x00012CE0 File Offset: 0x00010EE0
		public unsafe static Activity IN_VEHICLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_IN_VEHICLE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_IN_VEHICLE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x000CF45C File Offset: 0x000CD65C
		// (set) Token: 0x060030F0 RID: 12528 RVA: 0x00012CF2 File Offset: 0x00010EF2
		public unsafe static Activity INTERVAL_TRAINING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_INTERVAL_TRAINING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_INTERVAL_TRAINING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x000CF484 File Offset: 0x000CD684
		// (set) Token: 0x060030F2 RID: 12530 RVA: 0x00012D04 File Offset: 0x00010F04
		public unsafe static Activity JUMP_ROPE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_JUMP_ROPE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_JUMP_ROPE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060030F3 RID: 12531 RVA: 0x000CF4AC File Offset: 0x000CD6AC
		// (set) Token: 0x060030F4 RID: 12532 RVA: 0x00012D16 File Offset: 0x00010F16
		public unsafe static Activity KAYAKING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_KAYAKING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_KAYAKING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060030F5 RID: 12533 RVA: 0x000CF4D4 File Offset: 0x000CD6D4
		// (set) Token: 0x060030F6 RID: 12534 RVA: 0x00012D28 File Offset: 0x00010F28
		public unsafe static Activity KETTLEBELL_TRAINING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_KETTLEBELL_TRAINING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_KETTLEBELL_TRAINING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060030F7 RID: 12535 RVA: 0x000CF4FC File Offset: 0x000CD6FC
		// (set) Token: 0x060030F8 RID: 12536 RVA: 0x00012D3A File Offset: 0x00010F3A
		public unsafe static Activity KICK_SCOOTER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_KICK_SCOOTER, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_KICK_SCOOTER, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x000CF524 File Offset: 0x000CD724
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x00012D4C File Offset: 0x00010F4C
		public unsafe static Activity KICKBOXING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_KICKBOXING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_KICKBOXING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x000CF54C File Offset: 0x000CD74C
		// (set) Token: 0x060030FC RID: 12540 RVA: 0x00012D5E File Offset: 0x00010F5E
		public unsafe static Activity KITESURFING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_KITESURFING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_KITESURFING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x000CF574 File Offset: 0x000CD774
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x00012D70 File Offset: 0x00010F70
		public unsafe static Activity MARTIAL_ARTS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_MARTIAL_ARTS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_MARTIAL_ARTS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x000CF59C File Offset: 0x000CD79C
		// (set) Token: 0x06003100 RID: 12544 RVA: 0x00012D82 File Offset: 0x00010F82
		public unsafe static Activity MEDITATION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_MEDITATION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_MEDITATION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x000CF5C4 File Offset: 0x000CD7C4
		// (set) Token: 0x06003102 RID: 12546 RVA: 0x00012D94 File Offset: 0x00010F94
		public unsafe static Activity MIXED_MARTIAL_ARTS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_MIXED_MARTIAL_ARTS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_MIXED_MARTIAL_ARTS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x000CF5EC File Offset: 0x000CD7EC
		// (set) Token: 0x06003104 RID: 12548 RVA: 0x00012DA6 File Offset: 0x00010FA6
		public unsafe static Activity ON_FOOT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ON_FOOT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ON_FOOT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x000CF614 File Offset: 0x000CD814
		// (set) Token: 0x06003106 RID: 12550 RVA: 0x00012DB8 File Offset: 0x00010FB8
		public unsafe static Activity OTHER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_OTHER, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_OTHER, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x000CF63C File Offset: 0x000CD83C
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x00012DCA File Offset: 0x00010FCA
		public unsafe static Activity P90X
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_P90X, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_P90X, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000CF664 File Offset: 0x000CD864
		// (set) Token: 0x0600310A RID: 12554 RVA: 0x00012DDC File Offset: 0x00010FDC
		public unsafe static Activity PARAGLIDING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_PARAGLIDING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_PARAGLIDING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x000CF68C File Offset: 0x000CD88C
		// (set) Token: 0x0600310C RID: 12556 RVA: 0x00012DEE File Offset: 0x00010FEE
		public unsafe static Activity PILATES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_PILATES, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_PILATES, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x000CF6B4 File Offset: 0x000CD8B4
		// (set) Token: 0x0600310E RID: 12558 RVA: 0x00012E00 File Offset: 0x00011000
		public unsafe static Activity POLO
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_POLO, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_POLO, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x000CF6DC File Offset: 0x000CD8DC
		// (set) Token: 0x06003110 RID: 12560 RVA: 0x00012E12 File Offset: 0x00011012
		public unsafe static Activity RACQUETBALL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_RACQUETBALL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_RACQUETBALL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x000CF704 File Offset: 0x000CD904
		// (set) Token: 0x06003112 RID: 12562 RVA: 0x00012E24 File Offset: 0x00011024
		public unsafe static Activity ROCK_CLIMBING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ROCK_CLIMBING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ROCK_CLIMBING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06003113 RID: 12563 RVA: 0x000CF72C File Offset: 0x000CD92C
		// (set) Token: 0x06003114 RID: 12564 RVA: 0x00012E36 File Offset: 0x00011036
		public unsafe static Activity ROWING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ROWING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ROWING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x000CF754 File Offset: 0x000CD954
		// (set) Token: 0x06003116 RID: 12566 RVA: 0x00012E48 File Offset: 0x00011048
		public unsafe static Activity ROWING_MACHINE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ROWING_MACHINE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ROWING_MACHINE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06003117 RID: 12567 RVA: 0x000CF77C File Offset: 0x000CD97C
		// (set) Token: 0x06003118 RID: 12568 RVA: 0x00012E5A File Offset: 0x0001105A
		public unsafe static Activity RUGBY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_RUGBY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_RUGBY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x000CF7A4 File Offset: 0x000CD9A4
		// (set) Token: 0x0600311A RID: 12570 RVA: 0x00012E6C File Offset: 0x0001106C
		public unsafe static Activity RUNNING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_RUNNING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_RUNNING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x000CF7CC File Offset: 0x000CD9CC
		// (set) Token: 0x0600311C RID: 12572 RVA: 0x00012E7E File Offset: 0x0001107E
		public unsafe static Activity RUNNING_JOGGING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_RUNNING_JOGGING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_RUNNING_JOGGING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x000CF7F4 File Offset: 0x000CD9F4
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x00012E90 File Offset: 0x00011090
		public unsafe static Activity RUNNING_SAND
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_RUNNING_SAND, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_RUNNING_SAND, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x000CF81C File Offset: 0x000CDA1C
		// (set) Token: 0x06003120 RID: 12576 RVA: 0x00012EA2 File Offset: 0x000110A2
		public unsafe static Activity RUNNING_TREADMILL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_RUNNING_TREADMILL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_RUNNING_TREADMILL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x000CF844 File Offset: 0x000CDA44
		// (set) Token: 0x06003122 RID: 12578 RVA: 0x00012EB4 File Offset: 0x000110B4
		public unsafe static Activity SAILING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SAILING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SAILING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x000CF86C File Offset: 0x000CDA6C
		// (set) Token: 0x06003124 RID: 12580 RVA: 0x00012EC6 File Offset: 0x000110C6
		public unsafe static Activity SCUBA_DIVING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SCUBA_DIVING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SCUBA_DIVING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06003125 RID: 12581 RVA: 0x000CF894 File Offset: 0x000CDA94
		// (set) Token: 0x06003126 RID: 12582 RVA: 0x00012ED8 File Offset: 0x000110D8
		public unsafe static Activity SKATEBOARDING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKATEBOARDING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKATEBOARDING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x000CF8BC File Offset: 0x000CDABC
		// (set) Token: 0x06003128 RID: 12584 RVA: 0x00012EEA File Offset: 0x000110EA
		public unsafe static Activity SKATING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKATING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKATING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x000CF8E4 File Offset: 0x000CDAE4
		// (set) Token: 0x0600312A RID: 12586 RVA: 0x00012EFC File Offset: 0x000110FC
		public unsafe static Activity SKATING_CROSS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKATING_CROSS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKATING_CROSS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x000CF90C File Offset: 0x000CDB0C
		// (set) Token: 0x0600312C RID: 12588 RVA: 0x00012F0E File Offset: 0x0001110E
		public unsafe static Activity SKATING_INDOOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKATING_INDOOR, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKATING_INDOOR, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x000CF934 File Offset: 0x000CDB34
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x00012F20 File Offset: 0x00011120
		public unsafe static Activity SKATING_INLINE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKATING_INLINE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKATING_INLINE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x000CF95C File Offset: 0x000CDB5C
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x00012F32 File Offset: 0x00011132
		public unsafe static Activity SKIING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKIING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKIING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x000CF984 File Offset: 0x000CDB84
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x00012F44 File Offset: 0x00011144
		public unsafe static Activity SKIING_BACK_COUNTRY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKIING_BACK_COUNTRY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKIING_BACK_COUNTRY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x000CF9AC File Offset: 0x000CDBAC
		// (set) Token: 0x06003134 RID: 12596 RVA: 0x00012F56 File Offset: 0x00011156
		public unsafe static Activity SKIING_CROSS_COUNTRY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKIING_CROSS_COUNTRY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKIING_CROSS_COUNTRY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x000CF9D4 File Offset: 0x000CDBD4
		// (set) Token: 0x06003136 RID: 12598 RVA: 0x00012F68 File Offset: 0x00011168
		public unsafe static Activity SKIING_DOWNHILL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKIING_DOWNHILL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKIING_DOWNHILL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x000CF9FC File Offset: 0x000CDBFC
		// (set) Token: 0x06003138 RID: 12600 RVA: 0x00012F7A File Offset: 0x0001117A
		public unsafe static Activity SKIING_KITE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKIING_KITE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKIING_KITE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x000CFA24 File Offset: 0x000CDC24
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x00012F8C File Offset: 0x0001118C
		public unsafe static Activity SKIING_ROLLER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SKIING_ROLLER, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SKIING_ROLLER, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x0600313B RID: 12603 RVA: 0x000CFA4C File Offset: 0x000CDC4C
		// (set) Token: 0x0600313C RID: 12604 RVA: 0x00012F9E File Offset: 0x0001119E
		public unsafe static Activity SLEDDING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SLEDDING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SLEDDING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x000CFA74 File Offset: 0x000CDC74
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x00012FB0 File Offset: 0x000111B0
		public unsafe static Activity SLEEP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SLEEP, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SLEEP, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x000CFA9C File Offset: 0x000CDC9C
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x00012FC2 File Offset: 0x000111C2
		public unsafe static Activity SLEEP_LIGHT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SLEEP_LIGHT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SLEEP_LIGHT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x000CFAC4 File Offset: 0x000CDCC4
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x00012FD4 File Offset: 0x000111D4
		public unsafe static Activity SLEEP_DEEP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SLEEP_DEEP, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SLEEP_DEEP, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x000CFAEC File Offset: 0x000CDCEC
		// (set) Token: 0x06003144 RID: 12612 RVA: 0x00012FE6 File Offset: 0x000111E6
		public unsafe static Activity SLEEP_REM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SLEEP_REM, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SLEEP_REM, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x000CFB14 File Offset: 0x000CDD14
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x00012FF8 File Offset: 0x000111F8
		public unsafe static Activity SLEEP_AWAKE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SLEEP_AWAKE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SLEEP_AWAKE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x000CFB3C File Offset: 0x000CDD3C
		// (set) Token: 0x06003148 RID: 12616 RVA: 0x0001300A File Offset: 0x0001120A
		public unsafe static Activity SNOWBOARDING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SNOWBOARDING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SNOWBOARDING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06003149 RID: 12617 RVA: 0x000CFB64 File Offset: 0x000CDD64
		// (set) Token: 0x0600314A RID: 12618 RVA: 0x0001301C File Offset: 0x0001121C
		public unsafe static Activity SNOWMOBILE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SNOWMOBILE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SNOWMOBILE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x0600314B RID: 12619 RVA: 0x000CFB8C File Offset: 0x000CDD8C
		// (set) Token: 0x0600314C RID: 12620 RVA: 0x0001302E File Offset: 0x0001122E
		public unsafe static Activity SNOWSHOEING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SNOWSHOEING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SNOWSHOEING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x0600314D RID: 12621 RVA: 0x000CFBB4 File Offset: 0x000CDDB4
		// (set) Token: 0x0600314E RID: 12622 RVA: 0x00013040 File Offset: 0x00011240
		public unsafe static Activity SQUASH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SQUASH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SQUASH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x0600314F RID: 12623 RVA: 0x000CFBDC File Offset: 0x000CDDDC
		// (set) Token: 0x06003150 RID: 12624 RVA: 0x00013052 File Offset: 0x00011252
		public unsafe static Activity STAIR_CLIMBING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_STAIR_CLIMBING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_STAIR_CLIMBING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06003151 RID: 12625 RVA: 0x000CFC04 File Offset: 0x000CDE04
		// (set) Token: 0x06003152 RID: 12626 RVA: 0x00013064 File Offset: 0x00011264
		public unsafe static Activity STAIR_CLIMBING_MACHINE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_STAIR_CLIMBING_MACHINE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_STAIR_CLIMBING_MACHINE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06003153 RID: 12627 RVA: 0x000CFC2C File Offset: 0x000CDE2C
		// (set) Token: 0x06003154 RID: 12628 RVA: 0x00013076 File Offset: 0x00011276
		public unsafe static Activity STANDUP_PADDLEBOARDING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_STANDUP_PADDLEBOARDING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_STANDUP_PADDLEBOARDING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06003155 RID: 12629 RVA: 0x000CFC54 File Offset: 0x000CDE54
		// (set) Token: 0x06003156 RID: 12630 RVA: 0x00013088 File Offset: 0x00011288
		public unsafe static Activity STILL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_STILL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_STILL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x000CFC7C File Offset: 0x000CDE7C
		// (set) Token: 0x06003158 RID: 12632 RVA: 0x0001309A File Offset: 0x0001129A
		public unsafe static Activity STRENGTH_TRAINING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_STRENGTH_TRAINING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_STRENGTH_TRAINING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06003159 RID: 12633 RVA: 0x000CFCA4 File Offset: 0x000CDEA4
		// (set) Token: 0x0600315A RID: 12634 RVA: 0x000130AC File Offset: 0x000112AC
		public unsafe static Activity SURFING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SURFING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SURFING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600315B RID: 12635 RVA: 0x000CFCCC File Offset: 0x000CDECC
		// (set) Token: 0x0600315C RID: 12636 RVA: 0x000130BE File Offset: 0x000112BE
		public unsafe static Activity SWIMMING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SWIMMING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SWIMMING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x000CFCF4 File Offset: 0x000CDEF4
		// (set) Token: 0x0600315E RID: 12638 RVA: 0x000130D0 File Offset: 0x000112D0
		public unsafe static Activity SWIMMING_POOL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SWIMMING_POOL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SWIMMING_POOL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x0600315F RID: 12639 RVA: 0x000CFD1C File Offset: 0x000CDF1C
		// (set) Token: 0x06003160 RID: 12640 RVA: 0x000130E2 File Offset: 0x000112E2
		public unsafe static Activity SWIMMING_OPEN_WATER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_SWIMMING_OPEN_WATER, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_SWIMMING_OPEN_WATER, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06003161 RID: 12641 RVA: 0x000CFD44 File Offset: 0x000CDF44
		// (set) Token: 0x06003162 RID: 12642 RVA: 0x000130F4 File Offset: 0x000112F4
		public unsafe static Activity TABLE_TENNIS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_TABLE_TENNIS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_TABLE_TENNIS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06003163 RID: 12643 RVA: 0x000CFD6C File Offset: 0x000CDF6C
		// (set) Token: 0x06003164 RID: 12644 RVA: 0x00013106 File Offset: 0x00011306
		public unsafe static Activity TEAM_SPORTS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_TEAM_SPORTS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_TEAM_SPORTS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06003165 RID: 12645 RVA: 0x000CFD94 File Offset: 0x000CDF94
		// (set) Token: 0x06003166 RID: 12646 RVA: 0x00013118 File Offset: 0x00011318
		public unsafe static Activity TENNIS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_TENNIS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_TENNIS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06003167 RID: 12647 RVA: 0x000CFDBC File Offset: 0x000CDFBC
		// (set) Token: 0x06003168 RID: 12648 RVA: 0x0001312A File Offset: 0x0001132A
		public unsafe static Activity TILTING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_TILTING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_TILTING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x000CFDE4 File Offset: 0x000CDFE4
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x0001313C File Offset: 0x0001133C
		public unsafe static Activity TREADMILL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_TREADMILL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_TREADMILL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x000CFE0C File Offset: 0x000CE00C
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x0001314E File Offset: 0x0001134E
		public unsafe static Activity UNKNOWN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_UNKNOWN, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_UNKNOWN, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x000CFE34 File Offset: 0x000CE034
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x00013160 File Offset: 0x00011360
		public unsafe static Activity VOLLEYBALL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_VOLLEYBALL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_VOLLEYBALL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x000CFE5C File Offset: 0x000CE05C
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x00013172 File Offset: 0x00011372
		public unsafe static Activity VOLLEYBALL_BEACH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_VOLLEYBALL_BEACH, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_VOLLEYBALL_BEACH, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x000CFE84 File Offset: 0x000CE084
		// (set) Token: 0x06003172 RID: 12658 RVA: 0x00013184 File Offset: 0x00011384
		public unsafe static Activity VOLLEYBALL_INDOOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_VOLLEYBALL_INDOOR, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_VOLLEYBALL_INDOOR, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x000CFEAC File Offset: 0x000CE0AC
		// (set) Token: 0x06003174 RID: 12660 RVA: 0x00013196 File Offset: 0x00011396
		public unsafe static Activity WAKEBOARDING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_WAKEBOARDING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_WAKEBOARDING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x000CFED4 File Offset: 0x000CE0D4
		// (set) Token: 0x06003176 RID: 12662 RVA: 0x000131A8 File Offset: 0x000113A8
		public unsafe static Activity WALKING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_WALKING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_WALKING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x000CFEFC File Offset: 0x000CE0FC
		// (set) Token: 0x06003178 RID: 12664 RVA: 0x000131BA File Offset: 0x000113BA
		public unsafe static Activity WALKING_FITNESS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_WALKING_FITNESS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_WALKING_FITNESS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x000CFF24 File Offset: 0x000CE124
		// (set) Token: 0x0600317A RID: 12666 RVA: 0x000131CC File Offset: 0x000113CC
		public unsafe static Activity WALKING_NORDIC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_WALKING_NORDIC, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_WALKING_NORDIC, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600317B RID: 12667 RVA: 0x000CFF4C File Offset: 0x000CE14C
		// (set) Token: 0x0600317C RID: 12668 RVA: 0x000131DE File Offset: 0x000113DE
		public unsafe static Activity WALKING_TREADMILL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_WALKING_TREADMILL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_WALKING_TREADMILL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x000CFF74 File Offset: 0x000CE174
		// (set) Token: 0x0600317E RID: 12670 RVA: 0x000131F0 File Offset: 0x000113F0
		public unsafe static Activity WALKING_STROLLER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_WALKING_STROLLER, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_WALKING_STROLLER, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x0600317F RID: 12671 RVA: 0x000CFF9C File Offset: 0x000CE19C
		// (set) Token: 0x06003180 RID: 12672 RVA: 0x00013202 File Offset: 0x00011402
		public unsafe static Activity WATER_POLO
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_WATER_POLO, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_WATER_POLO, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x000CFFC4 File Offset: 0x000CE1C4
		// (set) Token: 0x06003182 RID: 12674 RVA: 0x00013214 File Offset: 0x00011414
		public unsafe static Activity WEIGHTLIFTING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_WEIGHTLIFTING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_WEIGHTLIFTING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x000CFFEC File Offset: 0x000CE1EC
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x00013226 File Offset: 0x00011426
		public unsafe static Activity WHEELCHAIR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_WHEELCHAIR, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_WHEELCHAIR, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x000D0014 File Offset: 0x000CE214
		// (set) Token: 0x06003186 RID: 12678 RVA: 0x00013238 File Offset: 0x00011438
		public unsafe static Activity WINDSURFING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_WINDSURFING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_WINDSURFING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x000D003C File Offset: 0x000CE23C
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x0001324A File Offset: 0x0001144A
		public unsafe static Activity YOGA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_YOGA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_YOGA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x000D0064 File Offset: 0x000CE264
		// (set) Token: 0x0600318A RID: 12682 RVA: 0x0001325C File Offset: 0x0001145C
		public unsafe static Activity ZUMBA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Activity.NativeFieldInfoPtr_ZUMBA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Activity.NativeFieldInfoPtr_ZUMBA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x000D008C File Offset: 0x000CE28C
		// (set) Token: 0x0600318C RID: 12684 RVA: 0x0001326E File Offset: 0x0001146E
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Activity.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002E26 RID: 11814
		private static readonly IntPtr NativeFieldInfoPtr_AEROBICS;

		// Token: 0x04002E27 RID: 11815
		private static readonly IntPtr NativeFieldInfoPtr_ARCHERY;

		// Token: 0x04002E28 RID: 11816
		private static readonly IntPtr NativeFieldInfoPtr_BADMINTON;

		// Token: 0x04002E29 RID: 11817
		private static readonly IntPtr NativeFieldInfoPtr_BASEBALL;

		// Token: 0x04002E2A RID: 11818
		private static readonly IntPtr NativeFieldInfoPtr_BASKETBALL;

		// Token: 0x04002E2B RID: 11819
		private static readonly IntPtr NativeFieldInfoPtr_BIATHLON;

		// Token: 0x04002E2C RID: 11820
		private static readonly IntPtr NativeFieldInfoPtr_BIKING;

		// Token: 0x04002E2D RID: 11821
		private static readonly IntPtr NativeFieldInfoPtr_BIKING_HAND;

		// Token: 0x04002E2E RID: 11822
		private static readonly IntPtr NativeFieldInfoPtr_BIKING_MOUNTAIN;

		// Token: 0x04002E2F RID: 11823
		private static readonly IntPtr NativeFieldInfoPtr_BIKING_ROAD;

		// Token: 0x04002E30 RID: 11824
		private static readonly IntPtr NativeFieldInfoPtr_BIKING_SPINNING;

		// Token: 0x04002E31 RID: 11825
		private static readonly IntPtr NativeFieldInfoPtr_BIKING_STATIONARY;

		// Token: 0x04002E32 RID: 11826
		private static readonly IntPtr NativeFieldInfoPtr_BIKING_UTILITY;

		// Token: 0x04002E33 RID: 11827
		private static readonly IntPtr NativeFieldInfoPtr_BOXING;

		// Token: 0x04002E34 RID: 11828
		private static readonly IntPtr NativeFieldInfoPtr_CALISTHENICS;

		// Token: 0x04002E35 RID: 11829
		private static readonly IntPtr NativeFieldInfoPtr_CIRCUIT_TRAINING;

		// Token: 0x04002E36 RID: 11830
		private static readonly IntPtr NativeFieldInfoPtr_CRICKET;

		// Token: 0x04002E37 RID: 11831
		private static readonly IntPtr NativeFieldInfoPtr_CROSSFIT;

		// Token: 0x04002E38 RID: 11832
		private static readonly IntPtr NativeFieldInfoPtr_CURLING;

		// Token: 0x04002E39 RID: 11833
		private static readonly IntPtr NativeFieldInfoPtr_DANCING;

		// Token: 0x04002E3A RID: 11834
		private static readonly IntPtr NativeFieldInfoPtr_DIVING;

		// Token: 0x04002E3B RID: 11835
		private static readonly IntPtr NativeFieldInfoPtr_ELEVATOR;

		// Token: 0x04002E3C RID: 11836
		private static readonly IntPtr NativeFieldInfoPtr_ELLIPTICAL;

		// Token: 0x04002E3D RID: 11837
		private static readonly IntPtr NativeFieldInfoPtr_ERGOMETER;

		// Token: 0x04002E3E RID: 11838
		private static readonly IntPtr NativeFieldInfoPtr_ESCALATOR;

		// Token: 0x04002E3F RID: 11839
		private static readonly IntPtr NativeFieldInfoPtr_FENCING;

		// Token: 0x04002E40 RID: 11840
		private static readonly IntPtr NativeFieldInfoPtr_FOOTBALL_AMERICAN;

		// Token: 0x04002E41 RID: 11841
		private static readonly IntPtr NativeFieldInfoPtr_FOOTBALL_AUSTRALIAN;

		// Token: 0x04002E42 RID: 11842
		private static readonly IntPtr NativeFieldInfoPtr_FOOTBALL_SOCCER;

		// Token: 0x04002E43 RID: 11843
		private static readonly IntPtr NativeFieldInfoPtr_FRISBEE_DISC;

		// Token: 0x04002E44 RID: 11844
		private static readonly IntPtr NativeFieldInfoPtr_GARDENING;

		// Token: 0x04002E45 RID: 11845
		private static readonly IntPtr NativeFieldInfoPtr_GOLF;

		// Token: 0x04002E46 RID: 11846
		private static readonly IntPtr NativeFieldInfoPtr_GYMNASTICS;

		// Token: 0x04002E47 RID: 11847
		private static readonly IntPtr NativeFieldInfoPtr_HANDBALL;

		// Token: 0x04002E48 RID: 11848
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_INTENSITY_INTERVAL_TRAINING;

		// Token: 0x04002E49 RID: 11849
		private static readonly IntPtr NativeFieldInfoPtr_HIKING;

		// Token: 0x04002E4A RID: 11850
		private static readonly IntPtr NativeFieldInfoPtr_HOCKEY;

		// Token: 0x04002E4B RID: 11851
		private static readonly IntPtr NativeFieldInfoPtr_HORSEBACK_RIDING;

		// Token: 0x04002E4C RID: 11852
		private static readonly IntPtr NativeFieldInfoPtr_HOUSEWORK;

		// Token: 0x04002E4D RID: 11853
		private static readonly IntPtr NativeFieldInfoPtr_ICE_SKATING;

		// Token: 0x04002E4E RID: 11854
		private static readonly IntPtr NativeFieldInfoPtr_IN_VEHICLE;

		// Token: 0x04002E4F RID: 11855
		private static readonly IntPtr NativeFieldInfoPtr_INTERVAL_TRAINING;

		// Token: 0x04002E50 RID: 11856
		private static readonly IntPtr NativeFieldInfoPtr_JUMP_ROPE;

		// Token: 0x04002E51 RID: 11857
		private static readonly IntPtr NativeFieldInfoPtr_KAYAKING;

		// Token: 0x04002E52 RID: 11858
		private static readonly IntPtr NativeFieldInfoPtr_KETTLEBELL_TRAINING;

		// Token: 0x04002E53 RID: 11859
		private static readonly IntPtr NativeFieldInfoPtr_KICK_SCOOTER;

		// Token: 0x04002E54 RID: 11860
		private static readonly IntPtr NativeFieldInfoPtr_KICKBOXING;

		// Token: 0x04002E55 RID: 11861
		private static readonly IntPtr NativeFieldInfoPtr_KITESURFING;

		// Token: 0x04002E56 RID: 11862
		private static readonly IntPtr NativeFieldInfoPtr_MARTIAL_ARTS;

		// Token: 0x04002E57 RID: 11863
		private static readonly IntPtr NativeFieldInfoPtr_MEDITATION;

		// Token: 0x04002E58 RID: 11864
		private static readonly IntPtr NativeFieldInfoPtr_MIXED_MARTIAL_ARTS;

		// Token: 0x04002E59 RID: 11865
		private static readonly IntPtr NativeFieldInfoPtr_ON_FOOT;

		// Token: 0x04002E5A RID: 11866
		private static readonly IntPtr NativeFieldInfoPtr_OTHER;

		// Token: 0x04002E5B RID: 11867
		private static readonly IntPtr NativeFieldInfoPtr_P90X;

		// Token: 0x04002E5C RID: 11868
		private static readonly IntPtr NativeFieldInfoPtr_PARAGLIDING;

		// Token: 0x04002E5D RID: 11869
		private static readonly IntPtr NativeFieldInfoPtr_PILATES;

		// Token: 0x04002E5E RID: 11870
		private static readonly IntPtr NativeFieldInfoPtr_POLO;

		// Token: 0x04002E5F RID: 11871
		private static readonly IntPtr NativeFieldInfoPtr_RACQUETBALL;

		// Token: 0x04002E60 RID: 11872
		private static readonly IntPtr NativeFieldInfoPtr_ROCK_CLIMBING;

		// Token: 0x04002E61 RID: 11873
		private static readonly IntPtr NativeFieldInfoPtr_ROWING;

		// Token: 0x04002E62 RID: 11874
		private static readonly IntPtr NativeFieldInfoPtr_ROWING_MACHINE;

		// Token: 0x04002E63 RID: 11875
		private static readonly IntPtr NativeFieldInfoPtr_RUGBY;

		// Token: 0x04002E64 RID: 11876
		private static readonly IntPtr NativeFieldInfoPtr_RUNNING;

		// Token: 0x04002E65 RID: 11877
		private static readonly IntPtr NativeFieldInfoPtr_RUNNING_JOGGING;

		// Token: 0x04002E66 RID: 11878
		private static readonly IntPtr NativeFieldInfoPtr_RUNNING_SAND;

		// Token: 0x04002E67 RID: 11879
		private static readonly IntPtr NativeFieldInfoPtr_RUNNING_TREADMILL;

		// Token: 0x04002E68 RID: 11880
		private static readonly IntPtr NativeFieldInfoPtr_SAILING;

		// Token: 0x04002E69 RID: 11881
		private static readonly IntPtr NativeFieldInfoPtr_SCUBA_DIVING;

		// Token: 0x04002E6A RID: 11882
		private static readonly IntPtr NativeFieldInfoPtr_SKATEBOARDING;

		// Token: 0x04002E6B RID: 11883
		private static readonly IntPtr NativeFieldInfoPtr_SKATING;

		// Token: 0x04002E6C RID: 11884
		private static readonly IntPtr NativeFieldInfoPtr_SKATING_CROSS;

		// Token: 0x04002E6D RID: 11885
		private static readonly IntPtr NativeFieldInfoPtr_SKATING_INDOOR;

		// Token: 0x04002E6E RID: 11886
		private static readonly IntPtr NativeFieldInfoPtr_SKATING_INLINE;

		// Token: 0x04002E6F RID: 11887
		private static readonly IntPtr NativeFieldInfoPtr_SKIING;

		// Token: 0x04002E70 RID: 11888
		private static readonly IntPtr NativeFieldInfoPtr_SKIING_BACK_COUNTRY;

		// Token: 0x04002E71 RID: 11889
		private static readonly IntPtr NativeFieldInfoPtr_SKIING_CROSS_COUNTRY;

		// Token: 0x04002E72 RID: 11890
		private static readonly IntPtr NativeFieldInfoPtr_SKIING_DOWNHILL;

		// Token: 0x04002E73 RID: 11891
		private static readonly IntPtr NativeFieldInfoPtr_SKIING_KITE;

		// Token: 0x04002E74 RID: 11892
		private static readonly IntPtr NativeFieldInfoPtr_SKIING_ROLLER;

		// Token: 0x04002E75 RID: 11893
		private static readonly IntPtr NativeFieldInfoPtr_SLEDDING;

		// Token: 0x04002E76 RID: 11894
		private static readonly IntPtr NativeFieldInfoPtr_SLEEP;

		// Token: 0x04002E77 RID: 11895
		private static readonly IntPtr NativeFieldInfoPtr_SLEEP_LIGHT;

		// Token: 0x04002E78 RID: 11896
		private static readonly IntPtr NativeFieldInfoPtr_SLEEP_DEEP;

		// Token: 0x04002E79 RID: 11897
		private static readonly IntPtr NativeFieldInfoPtr_SLEEP_REM;

		// Token: 0x04002E7A RID: 11898
		private static readonly IntPtr NativeFieldInfoPtr_SLEEP_AWAKE;

		// Token: 0x04002E7B RID: 11899
		private static readonly IntPtr NativeFieldInfoPtr_SNOWBOARDING;

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeFieldInfoPtr_SNOWMOBILE;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeFieldInfoPtr_SNOWSHOEING;

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeFieldInfoPtr_SQUASH;

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeFieldInfoPtr_STAIR_CLIMBING;

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeFieldInfoPtr_STAIR_CLIMBING_MACHINE;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeFieldInfoPtr_STANDUP_PADDLEBOARDING;

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeFieldInfoPtr_STILL;

		// Token: 0x04002E83 RID: 11907
		private static readonly IntPtr NativeFieldInfoPtr_STRENGTH_TRAINING;

		// Token: 0x04002E84 RID: 11908
		private static readonly IntPtr NativeFieldInfoPtr_SURFING;

		// Token: 0x04002E85 RID: 11909
		private static readonly IntPtr NativeFieldInfoPtr_SWIMMING;

		// Token: 0x04002E86 RID: 11910
		private static readonly IntPtr NativeFieldInfoPtr_SWIMMING_POOL;

		// Token: 0x04002E87 RID: 11911
		private static readonly IntPtr NativeFieldInfoPtr_SWIMMING_OPEN_WATER;

		// Token: 0x04002E88 RID: 11912
		private static readonly IntPtr NativeFieldInfoPtr_TABLE_TENNIS;

		// Token: 0x04002E89 RID: 11913
		private static readonly IntPtr NativeFieldInfoPtr_TEAM_SPORTS;

		// Token: 0x04002E8A RID: 11914
		private static readonly IntPtr NativeFieldInfoPtr_TENNIS;

		// Token: 0x04002E8B RID: 11915
		private static readonly IntPtr NativeFieldInfoPtr_TILTING;

		// Token: 0x04002E8C RID: 11916
		private static readonly IntPtr NativeFieldInfoPtr_TREADMILL;

		// Token: 0x04002E8D RID: 11917
		private static readonly IntPtr NativeFieldInfoPtr_UNKNOWN;

		// Token: 0x04002E8E RID: 11918
		private static readonly IntPtr NativeFieldInfoPtr_VOLLEYBALL;

		// Token: 0x04002E8F RID: 11919
		private static readonly IntPtr NativeFieldInfoPtr_VOLLEYBALL_BEACH;

		// Token: 0x04002E90 RID: 11920
		private static readonly IntPtr NativeFieldInfoPtr_VOLLEYBALL_INDOOR;

		// Token: 0x04002E91 RID: 11921
		private static readonly IntPtr NativeFieldInfoPtr_WAKEBOARDING;

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeFieldInfoPtr_WALKING;

		// Token: 0x04002E93 RID: 11923
		private static readonly IntPtr NativeFieldInfoPtr_WALKING_FITNESS;

		// Token: 0x04002E94 RID: 11924
		private static readonly IntPtr NativeFieldInfoPtr_WALKING_NORDIC;

		// Token: 0x04002E95 RID: 11925
		private static readonly IntPtr NativeFieldInfoPtr_WALKING_TREADMILL;

		// Token: 0x04002E96 RID: 11926
		private static readonly IntPtr NativeFieldInfoPtr_WALKING_STROLLER;

		// Token: 0x04002E97 RID: 11927
		private static readonly IntPtr NativeFieldInfoPtr_WATER_POLO;

		// Token: 0x04002E98 RID: 11928
		private static readonly IntPtr NativeFieldInfoPtr_WEIGHTLIFTING;

		// Token: 0x04002E99 RID: 11929
		private static readonly IntPtr NativeFieldInfoPtr_WHEELCHAIR;

		// Token: 0x04002E9A RID: 11930
		private static readonly IntPtr NativeFieldInfoPtr_WINDSURFING;

		// Token: 0x04002E9B RID: 11931
		private static readonly IntPtr NativeFieldInfoPtr_YOGA;

		// Token: 0x04002E9C RID: 11932
		private static readonly IntPtr NativeFieldInfoPtr_ZUMBA;

		// Token: 0x04002E9D RID: 11933
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002E9E RID: 11934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002E9F RID: 11935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
