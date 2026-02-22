using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI
{
	// Token: 0x0200001F RID: 31
	public class ILayoutElement : Il2CppObjectBase
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x00016F30 File Offset: 0x00015130
		// Note: this type is marked as 'beforefieldinit'.
		static ILayoutElement()
		{
			Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ILayoutElement");
			ILayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663903);
			ILayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663904);
			ILayoutElement.NativeMethodInfoPtr_get_minWidth_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663905);
			ILayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663906);
			ILayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663907);
			ILayoutElement.NativeMethodInfoPtr_get_minHeight_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663908);
			ILayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663909);
			ILayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663910);
			ILayoutElement.NativeMethodInfoPtr_get_layoutPriority_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayoutElement>.NativeClassPtr, 100663911);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0001700C File Offset: 0x0001520C
		[CallerCount(0)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00017048 File Offset: 0x00015248
		[CallerCount(0)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00017084 File Offset: 0x00015284
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_minWidth_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x000170CC File Offset: 0x000152CC
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_preferredWidth_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00017114 File Offset: 0x00015314
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_flexibleWidth_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0001715C File Offset: 0x0001535C
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_minHeight_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x000171A4 File Offset: 0x000153A4
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_preferredHeight_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x000171EC File Offset: 0x000153EC
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_flexibleHeight_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00017234 File Offset: 0x00015434
		public unsafe virtual int layoutPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayoutElement.NativeMethodInfoPtr_get_layoutPriority_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000374D File Offset: 0x0000194D
		public ILayoutElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
