using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Models;

namespace SA.Fitness
{
	// Token: 0x02000344 RID: 836
	public class StartSessionRequest : Object
	{
		// Token: 0x06003286 RID: 12934 RVA: 0x000D317C File Offset: 0x000D137C
		// Note: this type is marked as 'beforefieldinit'.
		static StartSessionRequest()
		{
			Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "StartSessionRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr);
			StartSessionRequest.NativeFieldInfoPtr_OnSessionStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, "OnSessionStarted");
			StartSessionRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, "id");
			StartSessionRequest.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, "name");
			StartSessionRequest.NativeFieldInfoPtr_sessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, "sessionId");
			StartSessionRequest.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, "description");
			StartSessionRequest.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, "startTime");
			StartSessionRequest.NativeFieldInfoPtr_timeUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, "timeUnit");
			StartSessionRequest.NativeFieldInfoPtr_activity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, "activity");
			StartSessionRequest.NativeMethodInfoPtr_add_OnSessionStarted_Public_add_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669780);
			StartSessionRequest.NativeMethodInfoPtr_remove_OnSessionStarted_Public_rem_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669781);
			StartSessionRequest.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669782);
			StartSessionRequest.NativeMethodInfoPtr_DispatchSessionStartResult_Public_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669783);
			StartSessionRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669784);
			StartSessionRequest.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669785);
			StartSessionRequest.NativeMethodInfoPtr_get_SessionId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669786);
			StartSessionRequest.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669787);
			StartSessionRequest.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669788);
			StartSessionRequest.NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669789);
			StartSessionRequest.NativeMethodInfoPtr_get_Activity_Public_get_Activity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, 100669790);
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x000D3328 File Offset: 0x000D1528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222599, RefRangeEnd = 222600, XrefRangeStart = 222595, XrefRangeEnd = 222599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnSessionStarted(Action<Result> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr_add_OnSessionStarted_Public_add_Void_Action_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x000D336C File Offset: 0x000D156C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222600, XrefRangeEnd = 222604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnSessionStarted(Action<Result> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr_remove_OnSessionStarted_Public_rem_Void_Action_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x000D33B0 File Offset: 0x000D15B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222630, RefRangeEnd = 222631, XrefRangeStart = 222604, XrefRangeEnd = 222630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartSessionRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000D33EC File Offset: 0x000D15EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222631, XrefRangeEnd = 222635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchSessionStartResult(Result result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr_DispatchSessionStartResult_Public_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x000D3430 File Offset: 0x000D1630
		public unsafe int Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600328C RID: 12940 RVA: 0x000D346C File Offset: 0x000D166C
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x000D34A4 File Offset: 0x000D16A4
		public unsafe string SessionId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr_get_SessionId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x000D34DC File Offset: 0x000D16DC
		public unsafe string Description
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x000D3514 File Offset: 0x000D1714
		public unsafe long StartTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x000D3550 File Offset: 0x000D1750
		public unsafe TimeUnit TimeUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06003291 RID: 12945 RVA: 0x000D358C File Offset: 0x000D178C
		public unsafe Activity Activity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.NativeMethodInfoPtr_get_Activity_Public_get_Activity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr3) : null;
			}
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00013A0E File Offset: 0x00011C0E
		public StartSessionRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06003293 RID: 12947 RVA: 0x000D35CC File Offset: 0x000D17CC
		// (set) Token: 0x06003294 RID: 12948 RVA: 0x00013A17 File Offset: 0x00011C17
		public unsafe Action<Result> OnSessionStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_OnSessionStarted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_OnSessionStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x000D35FC File Offset: 0x000D17FC
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x00013A36 File Offset: 0x00011C36
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x000D3624 File Offset: 0x000D1824
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x00013A51 File Offset: 0x00011C51
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06003299 RID: 12953 RVA: 0x000D364C File Offset: 0x000D184C
		// (set) Token: 0x0600329A RID: 12954 RVA: 0x00013A70 File Offset: 0x00011C70
		public unsafe string sessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_sessionId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_sessionId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x000D3674 File Offset: 0x000D1874
		// (set) Token: 0x0600329C RID: 12956 RVA: 0x00013A8F File Offset: 0x00011C8F
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x000D369C File Offset: 0x000D189C
		// (set) Token: 0x0600329E RID: 12958 RVA: 0x00013AAE File Offset: 0x00011CAE
		public unsafe long startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600329F RID: 12959 RVA: 0x000D36C4 File Offset: 0x000D18C4
		// (set) Token: 0x060032A0 RID: 12960 RVA: 0x00013AC9 File Offset: 0x00011CC9
		public unsafe TimeUnit timeUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_timeUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_timeUnit)) = value;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060032A1 RID: 12961 RVA: 0x000D36EC File Offset: 0x000D18EC
		// (set) Token: 0x060032A2 RID: 12962 RVA: 0x00013AE4 File Offset: 0x00011CE4
		public unsafe Activity activity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_activity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Activity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.NativeFieldInfoPtr_activity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F40 RID: 12096
		private static readonly IntPtr NativeFieldInfoPtr_OnSessionStarted;

		// Token: 0x04002F41 RID: 12097
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04002F42 RID: 12098
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002F43 RID: 12099
		private static readonly IntPtr NativeFieldInfoPtr_sessionId;

		// Token: 0x04002F44 RID: 12100
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x04002F45 RID: 12101
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04002F46 RID: 12102
		private static readonly IntPtr NativeFieldInfoPtr_timeUnit;

		// Token: 0x04002F47 RID: 12103
		private static readonly IntPtr NativeFieldInfoPtr_activity;

		// Token: 0x04002F48 RID: 12104
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSessionStarted_Public_add_Void_Action_1_Result_0;

		// Token: 0x04002F49 RID: 12105
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSessionStarted_Public_rem_Void_Action_1_Result_0;

		// Token: 0x04002F4A RID: 12106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002F4B RID: 12107
		private static readonly IntPtr NativeMethodInfoPtr_DispatchSessionStartResult_Public_Void_Result_0;

		// Token: 0x04002F4C RID: 12108
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002F4D RID: 12109
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002F4E RID: 12110
		private static readonly IntPtr NativeMethodInfoPtr_get_SessionId_Public_get_String_0;

		// Token: 0x04002F4F RID: 12111
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x04002F50 RID: 12112
		private static readonly IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Int64_0;

		// Token: 0x04002F51 RID: 12113
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeUnit_Public_get_TimeUnit_0;

		// Token: 0x04002F52 RID: 12114
		private static readonly IntPtr NativeMethodInfoPtr_get_Activity_Public_get_Activity_0;

		// Token: 0x020003ED RID: 1005
		public class Builder : Object
		{
			// Token: 0x060039C0 RID: 14784 RVA: 0x000E9DB4 File Offset: 0x000E7FB4
			// Note: this type is marked as 'beforefieldinit'.
			static Builder()
			{
				Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, "Builder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr);
				StartSessionRequest.Builder.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr, "request");
				StartSessionRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr, 100670576);
				StartSessionRequest.Builder.NativeMethodInfoPtr_SetName_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr, 100670577);
				StartSessionRequest.Builder.NativeMethodInfoPtr_SetIdentifier_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr, 100670578);
				StartSessionRequest.Builder.NativeMethodInfoPtr_SetDescription_Public_Builder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr, 100670579);
				StartSessionRequest.Builder.NativeMethodInfoPtr_SetStartTime_Public_Builder_Int64_TimeUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr, 100670580);
				StartSessionRequest.Builder.NativeMethodInfoPtr_SetActivity_Public_Builder_Activity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr, 100670581);
				StartSessionRequest.Builder.NativeMethodInfoPtr_Build_Public_StartSessionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr, 100670582);
			}

			// Token: 0x060039C1 RID: 14785 RVA: 0x000E9E80 File Offset: 0x000E8080
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222591, RefRangeEnd = 222592, XrefRangeStart = 222586, XrefRangeEnd = 222591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Builder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartSessionRequest.Builder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.Builder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039C2 RID: 14786 RVA: 0x000E9EBC File Offset: 0x000E80BC
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 221689, RefRangeEnd = 221698, XrefRangeStart = 221689, XrefRangeEnd = 221698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StartSessionRequest.Builder SetName(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.Builder.NativeMethodInfoPtr_SetName_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<StartSessionRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x060039C3 RID: 14787 RVA: 0x000E9F0C File Offset: 0x000E810C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222592, RefRangeEnd = 222594, XrefRangeStart = 222592, XrefRangeEnd = 222592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StartSessionRequest.Builder SetIdentifier(string id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.Builder.NativeMethodInfoPtr_SetIdentifier_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<StartSessionRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x060039C4 RID: 14788 RVA: 0x000E9F5C File Offset: 0x000E815C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 222117, RefRangeEnd = 222121, XrefRangeStart = 222117, XrefRangeEnd = 222121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StartSessionRequest.Builder SetDescription(string description)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.Builder.NativeMethodInfoPtr_SetDescription_Public_Builder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<StartSessionRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x060039C5 RID: 14789 RVA: 0x000E9FAC File Offset: 0x000E81AC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222333, RefRangeEnd = 222335, XrefRangeStart = 222333, XrefRangeEnd = 222335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StartSessionRequest.Builder SetStartTime(long startTime, TimeUnit timeUnit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref startTime;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeUnit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.Builder.NativeMethodInfoPtr_SetStartTime_Public_Builder_Int64_TimeUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StartSessionRequest.Builder>(intPtr3) : null;
			}

			// Token: 0x060039C6 RID: 14790 RVA: 0x000EA008 File Offset: 0x000E8208
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222594, RefRangeEnd = 222595, XrefRangeStart = 222594, XrefRangeEnd = 222594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StartSessionRequest.Builder SetActivity(Activity activity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(activity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.Builder.NativeMethodInfoPtr_SetActivity_Public_Builder_Activity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<StartSessionRequest.Builder>(intPtr3) : null;
				}
			}

			// Token: 0x060039C7 RID: 14791 RVA: 0x000EA058 File Offset: 0x000E8258
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StartSessionRequest Build()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.Builder.NativeMethodInfoPtr_Build_Public_StartSessionRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StartSessionRequest>(intPtr3) : null;
			}

			// Token: 0x060039C8 RID: 14792 RVA: 0x00016546 File Offset: 0x00014746
			public Builder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DAC RID: 3500
			// (get) Token: 0x060039C9 RID: 14793 RVA: 0x000EA098 File Offset: 0x000E8298
			// (set) Token: 0x060039CA RID: 14794 RVA: 0x0001654F File Offset: 0x0001474F
			public unsafe StartSessionRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.Builder.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartSessionRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartSessionRequest.Builder.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033C4 RID: 13252
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040033C5 RID: 13253
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033C6 RID: 13254
			private static readonly IntPtr NativeMethodInfoPtr_SetName_Public_Builder_String_0;

			// Token: 0x040033C7 RID: 13255
			private static readonly IntPtr NativeMethodInfoPtr_SetIdentifier_Public_Builder_String_0;

			// Token: 0x040033C8 RID: 13256
			private static readonly IntPtr NativeMethodInfoPtr_SetDescription_Public_Builder_String_0;

			// Token: 0x040033C9 RID: 13257
			private static readonly IntPtr NativeMethodInfoPtr_SetStartTime_Public_Builder_Int64_TimeUnit_0;

			// Token: 0x040033CA RID: 13258
			private static readonly IntPtr NativeMethodInfoPtr_SetActivity_Public_Builder_Activity_0;

			// Token: 0x040033CB RID: 13259
			private static readonly IntPtr NativeMethodInfoPtr_Build_Public_StartSessionRequest_0;
		}

		// Token: 0x020003EE RID: 1006
		[ObfuscatedName("SA.Fitness.StartSessionRequest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060039CB RID: 14795 RVA: 0x000EA0C8 File Offset: 0x000E82C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StartSessionRequest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartSessionRequest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartSessionRequest.__c>.NativeClassPtr);
				StartSessionRequest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest.__c>.NativeClassPtr, "<>9");
				StartSessionRequest.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartSessionRequest.__c>.NativeClassPtr, "<>9__10_0");
				StartSessionRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest.__c>.NativeClassPtr, 100670584);
				StartSessionRequest.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSessionRequest.__c>.NativeClassPtr, 100670585);
			}

			// Token: 0x060039CC RID: 14796 RVA: 0x000EA144 File Offset: 0x000E8344
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartSessionRequest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039CD RID: 14797 RVA: 0x000EA180 File Offset: 0x000E8380
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__10_0(Result <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartSessionRequest.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060039CE RID: 14798 RVA: 0x0001656E File Offset: 0x0001476E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DAD RID: 3501
			// (get) Token: 0x060039CF RID: 14799 RVA: 0x000EA1C4 File Offset: 0x000E83C4
			// (set) Token: 0x060039D0 RID: 14800 RVA: 0x00016577 File Offset: 0x00014777
			public unsafe static StartSessionRequest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StartSessionRequest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartSessionRequest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StartSessionRequest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DAE RID: 3502
			// (get) Token: 0x060039D1 RID: 14801 RVA: 0x000EA1EC File Offset: 0x000E83EC
			// (set) Token: 0x060039D2 RID: 14802 RVA: 0x00016589 File Offset: 0x00014789
			public unsafe static Action<Result> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StartSessionRequest.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StartSessionRequest.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040033CC RID: 13260
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040033CD RID: 13261
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040033CE RID: 13262
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040033CF RID: 13263
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_Result_0;
		}
	}
}
