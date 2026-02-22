using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E2 RID: 994
	[Serializable]
	public class CallContextRemotingData : Object
	{
		// Token: 0x06003F0E RID: 16142 RVA: 0x00125B24 File Offset: 0x00123D24
		// Note: this type is marked as 'beforefieldinit'.
		static CallContextRemotingData()
		{
			Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CallContextRemotingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr);
			CallContextRemotingData.NativeFieldInfoPtr__logicalCallID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, "_logicalCallID");
			CallContextRemotingData.NativeMethodInfoPtr_get_LogicalCallID_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100672536);
			CallContextRemotingData.NativeMethodInfoPtr_set_LogicalCallID_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100672537);
			CallContextRemotingData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100672538);
			CallContextRemotingData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100672539);
			CallContextRemotingData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr, 100672540);
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x00125BCC File Offset: 0x00123DCC
		// (set) Token: 0x06003F10 RID: 16144 RVA: 0x00125C04 File Offset: 0x00123E04
		public unsafe string LogicalCallID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_get_LogicalCallID_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_set_LogicalCallID_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06003F11 RID: 16145 RVA: 0x00125C48 File Offset: 0x00123E48
		public unsafe bool HasInfo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348766, RefRangeEnd = 348768, XrefRangeStart = 348766, XrefRangeEnd = 348768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x00125C84 File Offset: 0x00123E84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354236, RefRangeEnd = 354237, XrefRangeStart = 354232, XrefRangeEnd = 354236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x00125CC4 File Offset: 0x00123EC4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallContextRemotingData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallContextRemotingData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextRemotingData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x00017D43 File Offset: 0x00015F43
		public CallContextRemotingData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06003F15 RID: 16149 RVA: 0x00125D00 File Offset: 0x00123F00
		// (set) Token: 0x06003F16 RID: 16150 RVA: 0x00017D4C File Offset: 0x00015F4C
		public unsafe string _logicalCallID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextRemotingData.NativeFieldInfoPtr__logicalCallID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextRemotingData.NativeFieldInfoPtr__logicalCallID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033D4 RID: 13268
		private static readonly IntPtr NativeFieldInfoPtr__logicalCallID;

		// Token: 0x040033D5 RID: 13269
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallID_Internal_get_String_0;

		// Token: 0x040033D6 RID: 13270
		private static readonly IntPtr NativeMethodInfoPtr_set_LogicalCallID_Internal_set_Void_String_0;

		// Token: 0x040033D7 RID: 13271
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0;

		// Token: 0x040033D8 RID: 13272
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040033D9 RID: 13273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
