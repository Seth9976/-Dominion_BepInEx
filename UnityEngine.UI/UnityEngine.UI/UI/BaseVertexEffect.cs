using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200003E RID: 62
	public class BaseVertexEffect : Object
	{
		// Token: 0x060007F7 RID: 2039 RVA: 0x00025F5C File Offset: 0x0002415C
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVertexEffect()
		{
			Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "BaseVertexEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr);
			BaseVertexEffect.NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr, 100664468);
			BaseVertexEffect.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr, 100664469);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00025FB4 File Offset: 0x000241B4
		[CallerCount(0)]
		public unsafe virtual void ModifyVertices(List<UIVertex> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVertexEffect.NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00026004 File Offset: 0x00024204
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVertexEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVertexEffect.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00004C61 File Offset: 0x00002E61
		public BaseVertexEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
