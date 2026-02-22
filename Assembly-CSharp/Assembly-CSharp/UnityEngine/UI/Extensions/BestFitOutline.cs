using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000119 RID: 281
	public class BestFitOutline : Shadow
	{
		// Token: 0x06002069 RID: 8297 RVA: 0x0007C8FC File Offset: 0x0007AAFC
		// Note: this type is marked as 'beforefieldinit'.
		static BestFitOutline()
		{
			Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "BestFitOutline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr);
			BestFitOutline.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr, 100665934);
			BestFitOutline.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr, 100665935);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0007C954 File Offset: 0x0007AB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BestFitOutline()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BestFitOutline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BestFitOutline.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0007C990 File Offset: 0x0007AB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257458, XrefRangeEnd = 257501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BestFitOutline.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00014283 File Offset: 0x00012483
		public BestFitOutline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_Mesh_0;
	}
}
