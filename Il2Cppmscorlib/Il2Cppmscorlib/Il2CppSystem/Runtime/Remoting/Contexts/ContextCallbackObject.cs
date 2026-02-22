using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003B6 RID: 950
	public class ContextCallbackObject : ContextBoundObject
	{
		// Token: 0x06003DC6 RID: 15814 RVA: 0x001217C8 File Offset: 0x0011F9C8
		// Note: this type is marked as 'beforefieldinit'.
		static ContextCallbackObject()
		{
			Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "ContextCallbackObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr);
			ContextCallbackObject.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr, 100672386);
			ContextCallbackObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr, 100672387);
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x00121820 File Offset: 0x0011FA20
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallBack(CrossContextDelegate deleg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deleg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextCallbackObject.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x00121864 File Offset: 0x0011FA64
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextCallbackObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextCallbackObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x00017402 File Offset: 0x00015602
		public ContextCallbackObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003318 RID: 13080
		private static readonly IntPtr NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0;

		// Token: 0x04003319 RID: 13081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
