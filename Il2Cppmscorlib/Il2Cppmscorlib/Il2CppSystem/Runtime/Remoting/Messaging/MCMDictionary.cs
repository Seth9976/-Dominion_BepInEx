using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003FD RID: 1021
	public class MCMDictionary : MessageDictionary
	{
		// Token: 0x0600405B RID: 16475 RVA: 0x0012A76C File Offset: 0x0012896C
		// Note: this type is marked as 'beforefieldinit'.
		static MCMDictionary()
		{
			Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MCMDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr);
			MCMDictionary.NativeFieldInfoPtr_InternalKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr, "InternalKeys");
			MCMDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr, 100672691);
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x0012A7C4 File Offset: 0x001289C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 355215, RefRangeEnd = 355217, XrefRangeStart = 355210, XrefRangeEnd = 355215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MCMDictionary(IMethodMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MCMDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MCMDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x0001862C File Offset: 0x0001682C
		public MCMDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x0600405E RID: 16478 RVA: 0x0012A810 File Offset: 0x00128A10
		// (set) Token: 0x0600405F RID: 16479 RVA: 0x00018635 File Offset: 0x00016835
		public unsafe static Il2CppStringArray InternalKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MCMDictionary.NativeFieldInfoPtr_InternalKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MCMDictionary.NativeFieldInfoPtr_InternalKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034AE RID: 13486
		private static readonly IntPtr NativeFieldInfoPtr_InternalKeys;

		// Token: 0x040034AF RID: 13487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;
	}
}
