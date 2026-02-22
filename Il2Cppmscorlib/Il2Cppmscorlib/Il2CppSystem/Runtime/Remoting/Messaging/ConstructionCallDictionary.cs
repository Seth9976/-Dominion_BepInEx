using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Activation;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003EF RID: 1007
	public class ConstructionCallDictionary : MessageDictionary
	{
		// Token: 0x06003FDB RID: 16347 RVA: 0x001288F8 File Offset: 0x00126AF8
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionCallDictionary()
		{
			Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ConstructionCallDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr);
			ConstructionCallDictionary.NativeFieldInfoPtr_InternalKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, "InternalKeys");
			ConstructionCallDictionary.NativeMethodInfoPtr__ctor_Public_Void_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, 100672620);
			ConstructionCallDictionary.NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, 100672621);
			ConstructionCallDictionary.NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, 100672622);
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x00128978 File Offset: 0x00126B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354841, XrefRangeEnd = 354846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionCallDictionary(IConstructionCallMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCallDictionary.NativeMethodInfoPtr__ctor_Public_Void_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x001289C4 File Offset: 0x00126BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354846, XrefRangeEnd = 354905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetMethodProperty(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCallDictionary.NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x00128A20 File Offset: 0x00126C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354905, XrefRangeEnd = 354991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetMethodProperty(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCallDictionary.NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x00018365 File Offset: 0x00016565
		public ConstructionCallDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06003FE0 RID: 16352 RVA: 0x00128A80 File Offset: 0x00126C80
		// (set) Token: 0x06003FE1 RID: 16353 RVA: 0x0001836E File Offset: 0x0001656E
		public unsafe static Il2CppStringArray InternalKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConstructionCallDictionary.NativeFieldInfoPtr_InternalKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstructionCallDictionary.NativeFieldInfoPtr_InternalKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400345B RID: 13403
		private static readonly IntPtr NativeFieldInfoPtr_InternalKeys;

		// Token: 0x0400345C RID: 13404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IConstructionCallMessage_0;

		// Token: 0x0400345D RID: 13405
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_Object_String_0;

		// Token: 0x0400345E RID: 13406
		private static readonly IntPtr NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_Void_String_Object_0;
	}
}
