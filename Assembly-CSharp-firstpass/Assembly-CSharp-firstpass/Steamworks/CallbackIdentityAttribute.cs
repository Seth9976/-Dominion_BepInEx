using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002BE RID: 702
	public class CallbackIdentityAttribute : Attribute
	{
		// Token: 0x06002842 RID: 10306 RVA: 0x000AEBC8 File Offset: 0x000ACDC8
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackIdentityAttribute()
		{
			Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CallbackIdentityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr);
			CallbackIdentityAttribute.NativeFieldInfoPtr__Identity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr, "<Identity>k__BackingField");
			CallbackIdentityAttribute.NativeMethodInfoPtr_get_Identity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr, 100668446);
			CallbackIdentityAttribute.NativeMethodInfoPtr_set_Identity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr, 100668447);
			CallbackIdentityAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr, 100668448);
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x000AEC48 File Offset: 0x000ACE48
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x000AEC84 File Offset: 0x000ACE84
		public unsafe int Identity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackIdentityAttribute.NativeMethodInfoPtr_get_Identity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackIdentityAttribute.NativeMethodInfoPtr_set_Identity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000AECC4 File Offset: 0x000ACEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallbackIdentityAttribute(int callbackNum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackIdentityAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref callbackNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackIdentityAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00010461 File Offset: 0x0000E661
		public CallbackIdentityAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x000AED0C File Offset: 0x000ACF0C
		// (set) Token: 0x06002848 RID: 10312 RVA: 0x0001046A File Offset: 0x0000E66A
		public unsafe int _Identity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackIdentityAttribute.NativeFieldInfoPtr__Identity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackIdentityAttribute.NativeFieldInfoPtr__Identity_k__BackingField)) = value;
			}
		}

		// Token: 0x0400273E RID: 10046
		private static readonly IntPtr NativeFieldInfoPtr__Identity_k__BackingField;

		// Token: 0x0400273F RID: 10047
		private static readonly IntPtr NativeMethodInfoPtr_get_Identity_Public_get_Int32_0;

		// Token: 0x04002740 RID: 10048
		private static readonly IntPtr NativeMethodInfoPtr_set_Identity_Public_set_Void_Int32_0;

		// Token: 0x04002741 RID: 10049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
