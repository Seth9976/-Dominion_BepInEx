using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x02000041 RID: 65
	public class IMeshModifier : Il2CppObjectBase
	{
		// Token: 0x06000809 RID: 2057 RVA: 0x00026360 File Offset: 0x00024560
		// Note: this type is marked as 'beforefieldinit'.
		static IMeshModifier()
		{
			Il2CppClassPointerStore<IMeshModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IMeshModifier");
			IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMeshModifier>.NativeClassPtr, 100664478);
			IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMeshModifier>.NativeClassPtr, 100664479);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000263B0 File Offset: 0x000245B0
		[CallerCount(0)]
		public unsafe virtual void ModifyMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00026400 File Offset: 0x00024600
		[CallerCount(0)]
		public unsafe virtual void ModifyMesh(VertexHelper verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMeshModifier.NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00004CCA File Offset: 0x00002ECA
		public IMeshModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_Mesh_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Abstract_Virtual_New_Void_VertexHelper_0;
	}
}
