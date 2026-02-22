using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x0200002C RID: 44
	public class IMaterialModifier : Il2CppObjectBase
	{
		// Token: 0x06000522 RID: 1314 RVA: 0x00003BE4 File Offset: 0x00001DE4
		// Note: this type is marked as 'beforefieldinit'.
		static IMaterialModifier()
		{
			Il2CppClassPointerStore<IMaterialModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IMaterialModifier");
			IMaterialModifier.NativeMethodInfoPtr_GetModifiedMaterial_Public_Abstract_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMaterialModifier>.NativeClassPtr, 100664054);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001ADDC File Offset: 0x00018FDC
		[CallerCount(0)]
		public unsafe virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMaterialModifier.NativeMethodInfoPtr_GetModifiedMaterial_Public_Abstract_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00003C13 File Offset: 0x00001E13
		public IMaterialModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_GetModifiedMaterial_Public_Abstract_Virtual_New_Material_Material_0;
	}
}
