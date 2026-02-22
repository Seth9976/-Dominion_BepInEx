using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002BD RID: 701
	public class CallbackIdentities : Object
	{
		// Token: 0x0600283E RID: 10302 RVA: 0x000AEAF0 File Offset: 0x000ACCF0
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackIdentities()
		{
			Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CallbackIdentities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr);
			CallbackIdentities.NativeMethodInfoPtr_GetCallbackIdentity_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr, 100668444);
			CallbackIdentities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr, 100668445);
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x000AEB48 File Offset: 0x000ACD48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207521, RefRangeEnd = 207523, XrefRangeStart = 207513, XrefRangeEnd = 207521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCallbackIdentity(Type callbackStruct)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackStruct);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackIdentities.NativeMethodInfoPtr_GetCallbackIdentity_Public_Static_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000AEB8C File Offset: 0x000ACD8C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallbackIdentities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackIdentities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackIdentities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00010458 File Offset: 0x0000E658
		public CallbackIdentities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400273C RID: 10044
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackIdentity_Public_Static_Int32_Type_0;

		// Token: 0x0400273D RID: 10045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
