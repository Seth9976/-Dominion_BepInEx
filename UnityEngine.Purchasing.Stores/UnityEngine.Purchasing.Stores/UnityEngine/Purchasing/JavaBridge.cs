using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000034 RID: 52
	public class JavaBridge : AndroidJavaProxy
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x0000B9EC File Offset: 0x00009BEC
		// Note: this type is marked as 'beforefieldinit'.
		static JavaBridge()
		{
			Il2CppClassPointerStore<JavaBridge>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "JavaBridge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JavaBridge>.NativeClassPtr);
			JavaBridge.NativeFieldInfoPtr_forwardTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaBridge>.NativeClassPtr, "forwardTo");
			JavaBridge.NativeMethodInfoPtr__ctor_Public_Void_IUnityCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaBridge>.NativeClassPtr, 100663507);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000BA44 File Offset: 0x00009C44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151793, RefRangeEnd = 151795, XrefRangeStart = 151787, XrefRangeEnd = 151793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JavaBridge(IUnityCallback forwardTo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JavaBridge>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(forwardTo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JavaBridge.NativeMethodInfoPtr__ctor_Public_Void_IUnityCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002D92 File Offset: 0x00000F92
		public JavaBridge(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000BA90 File Offset: 0x00009C90
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002D9B File Offset: 0x00000F9B
		public unsafe IUnityCallback forwardTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaBridge.NativeFieldInfoPtr_forwardTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUnityCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JavaBridge.NativeFieldInfoPtr_forwardTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_forwardTo;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IUnityCallback_0;
	}
}
