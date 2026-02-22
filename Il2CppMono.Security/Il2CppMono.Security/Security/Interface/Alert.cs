using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x0200001A RID: 26
	public class Alert : Object
	{
		// Token: 0x0600016A RID: 362 RVA: 0x00008B00 File Offset: 0x00006D00
		// Note: this type is marked as 'beforefieldinit'.
		static Alert()
		{
			Il2CppClassPointerStore<Alert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "Alert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Alert>.NativeClassPtr);
			Alert.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alert>.NativeClassPtr, "level");
			Alert.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alert>.NativeClassPtr, "description");
			Alert.NativeMethodInfoPtr_get_Level_Public_get_AlertLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100663490);
			Alert.NativeMethodInfoPtr_get_Description_Public_get_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100663491);
			Alert.NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100663492);
			Alert.NativeMethodInfoPtr_inferAlertLevel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100663493);
			Alert.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100663494);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00008BBC File Offset: 0x00006DBC
		public unsafe AlertLevel Level
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alert.NativeMethodInfoPtr_get_Level_Public_get_AlertLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00008BF8 File Offset: 0x00006DF8
		public unsafe AlertDescription Description
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alert.NativeMethodInfoPtr_get_Description_Public_get_AlertDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00008C34 File Offset: 0x00006E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9043, XrefRangeEnd = 9044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Alert(AlertDescription description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Alert>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref description;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alert.NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00008C7C File Offset: 0x00006E7C
		[CallerCount(0)]
		public unsafe void inferAlertLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alert.NativeMethodInfoPtr_inferAlertLevel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008CB0 File Offset: 0x00006EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 9044, XrefRangeEnd = 9053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Alert.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002A29 File Offset: 0x00000C29
		public Alert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00008CF4 File Offset: 0x00006EF4
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002A32 File Offset: 0x00000C32
		public unsafe AlertLevel level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00008D1C File Offset: 0x00006F1C
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002A4D File Offset: 0x00000C4D
		public unsafe AlertDescription description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_description);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_description)) = value;
			}
		}

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_AlertLevel_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_AlertDescription_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_inferAlertLevel_Private_Void_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
