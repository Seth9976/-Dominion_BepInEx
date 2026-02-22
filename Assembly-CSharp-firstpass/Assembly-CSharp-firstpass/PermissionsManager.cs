using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

// Token: 0x020000DD RID: 221
public class PermissionsManager : Singleton<PermissionsManager>
{
	// Token: 0x06000FDF RID: 4063 RVA: 0x0004F268 File Offset: 0x0004D468
	// Note: this type is marked as 'beforefieldinit'.
	static PermissionsManager()
	{
		Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PermissionsManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr);
		PermissionsManager.NativeFieldInfoPtr_PM_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, "PM_CLASS_NAME");
		PermissionsManager.NativeFieldInfoPtr_ActionPermissionsRequestCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, "ActionPermissionsRequestCompleted");
		PermissionsManager.NativeMethodInfoPtr_add_ActionPermissionsRequestCompleted_Public_Static_add_Void_Action_1_AN_GrantPermissionsResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665276);
		PermissionsManager.NativeMethodInfoPtr_remove_ActionPermissionsRequestCompleted_Public_Static_rem_Void_Action_1_AN_GrantPermissionsResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665277);
		PermissionsManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665278);
		PermissionsManager.NativeMethodInfoPtr_IsPermissionGranted_Public_Static_Boolean_AN_Permission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665279);
		PermissionsManager.NativeMethodInfoPtr_IsPermissionGranted_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665280);
		PermissionsManager.NativeMethodInfoPtr_ShouldShowRequestPermission_Public_Static_Boolean_AN_Permission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665281);
		PermissionsManager.NativeMethodInfoPtr_RequestPermissions_Public_Void_Il2CppStructArray_1_AN_Permission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665282);
		PermissionsManager.NativeMethodInfoPtr_RequestPermissions_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665283);
		PermissionsManager.NativeMethodInfoPtr_OnPermissionsResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665284);
		PermissionsManager.NativeMethodInfoPtr_GetPermissionByName_Public_Static_AN_Permission_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665285);
		PermissionsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, 100665286);
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x0004F39C File Offset: 0x0004D59C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180858, XrefRangeEnd = 180869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPermissionsRequestCompleted(Action<AN_GrantPermissionsResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr_add_ActionPermissionsRequestCompleted_Public_Static_add_Void_Action_1_AN_GrantPermissionsResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x0004F3D4 File Offset: 0x0004D5D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180869, XrefRangeEnd = 180880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPermissionsRequestCompleted(Action<AN_GrantPermissionsResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr_remove_ActionPermissionsRequestCompleted_Public_Static_rem_Void_Action_1_AN_GrantPermissionsResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x0004F40C File Offset: 0x0004D60C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180880, XrefRangeEnd = 180885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x0004F440 File Offset: 0x0004D640
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180885, XrefRangeEnd = 180889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPermissionGranted(AN_Permission permission)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref permission;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr_IsPermissionGranted_Public_Static_Boolean_AN_Permission_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x0004F480 File Offset: 0x0004D680
	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPermissionGranted(string permission)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(permission);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr_IsPermissionGranted_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x0004F4C4 File Offset: 0x0004D6C4
	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldShowRequestPermission(AN_Permission permission)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref permission;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr_ShouldShowRequestPermission_Public_Static_Boolean_AN_Permission_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x0004F504 File Offset: 0x0004D704
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180934, RefRangeEnd = 180935, XrefRangeStart = 180889, XrefRangeEnd = 180934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestPermissions([Optional] Il2CppStructArray<AN_Permission> permissions)
	{
		if (permissions == null)
		{
			permissions = new Il2CppStructArray<AN_Permission>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(permissions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr_RequestPermissions_Public_Void_Il2CppStructArray_1_AN_Permission_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x0004F554 File Offset: 0x0004D754
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180935, XrefRangeEnd = 180950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestPermissions([Optional] Il2CppStringArray permissions)
	{
		if (permissions == null)
		{
			permissions = new Il2CppStringArray(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(permissions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr_RequestPermissions_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x0004F5A4 File Offset: 0x0004D7A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180950, XrefRangeEnd = 180999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPermissionsResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr_OnPermissionsResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x0004F5E8 File Offset: 0x0004D7E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181027, RefRangeEnd = 181028, XrefRangeStart = 180999, XrefRangeEnd = 181027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AN_Permission GetPermissionByName(string fullName)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fullName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr_GetPermissionByName_Public_Static_AN_Permission_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x0004F62C File Offset: 0x0004D82C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181028, XrefRangeEnd = 181034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PermissionsManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00007F0D File Offset: 0x0000610D
	public void RequestPermissions(params AN_Permission[] permissions)
	{
		this.RequestPermissions(new Il2CppStructArray<AN_Permission>(permissions));
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x00007F1B File Offset: 0x0000611B
	public void RequestPermissions(params string[] permissions)
	{
		this.RequestPermissions(new Il2CppStringArray(permissions));
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x00007F29 File Offset: 0x00006129
	public PermissionsManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700049F RID: 1183
	// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0004F668 File Offset: 0x0004D868
	// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00007F32 File Offset: 0x00006132
	public unsafe static string PM_CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PermissionsManager.NativeFieldInfoPtr_PM_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PermissionsManager.NativeFieldInfoPtr_PM_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004A0 RID: 1184
	// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0004F688 File Offset: 0x0004D888
	// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x00007F44 File Offset: 0x00006144
	public unsafe static Action<AN_GrantPermissionsResult> ActionPermissionsRequestCompleted
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PermissionsManager.NativeFieldInfoPtr_ActionPermissionsRequestCompleted, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AN_GrantPermissionsResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PermissionsManager.NativeFieldInfoPtr_ActionPermissionsRequestCompleted, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000C93 RID: 3219
	private static readonly IntPtr NativeFieldInfoPtr_PM_CLASS_NAME;

	// Token: 0x04000C94 RID: 3220
	private static readonly IntPtr NativeFieldInfoPtr_ActionPermissionsRequestCompleted;

	// Token: 0x04000C95 RID: 3221
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPermissionsRequestCompleted_Public_Static_add_Void_Action_1_AN_GrantPermissionsResult_0;

	// Token: 0x04000C96 RID: 3222
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPermissionsRequestCompleted_Public_Static_rem_Void_Action_1_AN_GrantPermissionsResult_0;

	// Token: 0x04000C97 RID: 3223
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000C98 RID: 3224
	private static readonly IntPtr NativeMethodInfoPtr_IsPermissionGranted_Public_Static_Boolean_AN_Permission_0;

	// Token: 0x04000C99 RID: 3225
	private static readonly IntPtr NativeMethodInfoPtr_IsPermissionGranted_Public_Static_Boolean_String_0;

	// Token: 0x04000C9A RID: 3226
	private static readonly IntPtr NativeMethodInfoPtr_ShouldShowRequestPermission_Public_Static_Boolean_AN_Permission_0;

	// Token: 0x04000C9B RID: 3227
	private static readonly IntPtr NativeMethodInfoPtr_RequestPermissions_Public_Void_Il2CppStructArray_1_AN_Permission_0;

	// Token: 0x04000C9C RID: 3228
	private static readonly IntPtr NativeMethodInfoPtr_RequestPermissions_Public_Void_Il2CppStringArray_0;

	// Token: 0x04000C9D RID: 3229
	private static readonly IntPtr NativeMethodInfoPtr_OnPermissionsResult_Private_Void_String_0;

	// Token: 0x04000C9E RID: 3230
	private static readonly IntPtr NativeMethodInfoPtr_GetPermissionByName_Public_Static_AN_Permission_String_0;

	// Token: 0x04000C9F RID: 3231
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000394 RID: 916
	[ObfuscatedName("PermissionsManager+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06003674 RID: 13940 RVA: 0x000DF6FC File Offset: 0x000DD8FC
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<PermissionsManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PermissionsManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PermissionsManager.__c>.NativeClassPtr);
			PermissionsManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionsManager.__c>.NativeClassPtr, "<>9");
			PermissionsManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager.__c>.NativeClassPtr, 100670224);
			PermissionsManager.__c.NativeMethodInfoPtr___cctor_b__13_0_Internal_Void_AN_GrantPermissionsResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsManager.__c>.NativeClassPtr, 100670225);
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x000DF764 File Offset: 0x000DD964
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PermissionsManager.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x000DF7A0 File Offset: 0x000DD9A0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__13_0(AN_GrantPermissionsResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsManager.__c.NativeMethodInfoPtr___cctor_b__13_0_Internal_Void_AN_GrantPermissionsResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x000151F4 File Offset: 0x000133F4
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06003678 RID: 13944 RVA: 0x000DF7E4 File Offset: 0x000DD9E4
		// (set) Token: 0x06003679 RID: 13945 RVA: 0x000151FD File Offset: 0x000133FD
		public unsafe static PermissionsManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PermissionsManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PermissionsManager.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PermissionsManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031CF RID: 12751
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040031D0 RID: 12752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031D1 RID: 12753
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__13_0_Internal_Void_AN_GrantPermissionsResult_0;
	}
}
