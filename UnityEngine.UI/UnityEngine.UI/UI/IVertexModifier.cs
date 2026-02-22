using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000040 RID: 64
	public class IVertexModifier : Il2CppObjectBase
	{
		// Token: 0x06000806 RID: 2054 RVA: 0x00004C92 File Offset: 0x00002E92
		// Note: this type is marked as 'beforefieldinit'.
		static IVertexModifier()
		{
			Il2CppClassPointerStore<IVertexModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IVertexModifier");
			IVertexModifier.NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVertexModifier>.NativeClassPtr, 100664477);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00026310 File Offset: 0x00024510
		[CallerCount(0)]
		public unsafe virtual void ModifyVertices(List<UIVertex> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVertexModifier.NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00004CC1 File Offset: 0x00002EC1
		public IVertexModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0;
	}
}
