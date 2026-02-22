using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000043 RID: 67
	public class PositionAsUV1 : BaseMeshEffect
	{
		// Token: 0x06000811 RID: 2065 RVA: 0x00026534 File Offset: 0x00024734
		// Note: this type is marked as 'beforefieldinit'.
		static PositionAsUV1()
		{
			Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "PositionAsUV1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr);
			PositionAsUV1.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr, 100664482);
			PositionAsUV1.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr, 100664483);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0002658C File Offset: 0x0002478C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120228, XrefRangeEnd = 120229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PositionAsUV1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionAsUV1.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000265C8 File Offset: 0x000247C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120229, XrefRangeEnd = 120234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PositionAsUV1.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00004CDC File Offset: 0x00002EDC
		public PositionAsUV1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;
	}
}
