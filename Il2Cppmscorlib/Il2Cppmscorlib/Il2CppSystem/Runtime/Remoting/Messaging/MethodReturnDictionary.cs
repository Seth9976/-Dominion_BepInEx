using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000400 RID: 1024
	public class MethodReturnDictionary : MessageDictionary
	{
		// Token: 0x060040B5 RID: 16565 RVA: 0x0012BD38 File Offset: 0x00129F38
		// Note: this type is marked as 'beforefieldinit'.
		static MethodReturnDictionary()
		{
			Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MethodReturnDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr);
			MethodReturnDictionary.NativeFieldInfoPtr_InternalReturnKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, "InternalReturnKeys");
			MethodReturnDictionary.NativeFieldInfoPtr_InternalExceptionKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, "InternalExceptionKeys");
			MethodReturnDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr, 100672743);
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x0012BDA4 File Offset: 0x00129FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355637, RefRangeEnd = 355638, XrefRangeStart = 355629, XrefRangeEnd = 355637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodReturnDictionary(IMethodReturnMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodReturnDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodReturnDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x000188A2 File Offset: 0x00016AA2
		public MethodReturnDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x060040B8 RID: 16568 RVA: 0x0012BDF0 File Offset: 0x00129FF0
		// (set) Token: 0x060040B9 RID: 16569 RVA: 0x000188AB File Offset: 0x00016AAB
		public unsafe static Il2CppStringArray InternalReturnKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalReturnKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalReturnKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x0012BE18 File Offset: 0x0012A018
		// (set) Token: 0x060040BB RID: 16571 RVA: 0x000188BD File Offset: 0x00016ABD
		public unsafe static Il2CppStringArray InternalExceptionKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalExceptionKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MethodReturnDictionary.NativeFieldInfoPtr_InternalExceptionKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034EE RID: 13550
		private static readonly IntPtr NativeFieldInfoPtr_InternalReturnKeys;

		// Token: 0x040034EF RID: 13551
		private static readonly IntPtr NativeFieldInfoPtr_InternalExceptionKeys;

		// Token: 0x040034F0 RID: 13552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodReturnMessage_0;
	}
}
