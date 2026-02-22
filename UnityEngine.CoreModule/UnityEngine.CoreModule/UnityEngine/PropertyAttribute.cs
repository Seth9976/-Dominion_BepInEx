using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008F RID: 143
	public class PropertyAttribute : Attribute
	{
		// Token: 0x06000F1F RID: 3871 RVA: 0x000099B9 File Offset: 0x00007BB9
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyAttribute()
		{
			Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr);
			PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr, 100664256);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0003F514 File Offset: 0x0003D714
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x000099F2 File Offset: 0x00007BF2
		public PropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x000099FB File Offset: 0x00007BFB
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x00009A08 File Offset: 0x00007C08
		public int order
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
