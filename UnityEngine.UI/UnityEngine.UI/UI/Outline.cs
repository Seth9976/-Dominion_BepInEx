using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000042 RID: 66
	public class Outline : Shadow
	{
		// Token: 0x0600080D RID: 2061 RVA: 0x00026450 File Offset: 0x00024650
		// Note: this type is marked as 'beforefieldinit'.
		static Outline()
		{
			Il2CppClassPointerStore<Outline>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Outline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Outline>.NativeClassPtr);
			Outline.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outline>.NativeClassPtr, 100664480);
			Outline.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outline>.NativeClassPtr, 100664481);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000264A8 File Offset: 0x000246A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120198, XrefRangeEnd = 120199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Outline()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Outline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Outline.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000264E4 File Offset: 0x000246E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120199, XrefRangeEnd = 120228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Outline.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00004CD3 File Offset: 0x00002ED3
		public Outline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;
	}
}
