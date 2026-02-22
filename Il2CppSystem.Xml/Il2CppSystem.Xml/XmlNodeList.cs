using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003E RID: 62
	[DefaultMember("Item")]
	public class XmlNodeList : Object
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x00020E48 File Offset: 0x0001F048
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeList()
		{
			Il2CppClassPointerStore<XmlNodeList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNodeList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNodeList>.NativeClassPtr);
			XmlNodeList.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeList>.NativeClassPtr, 100664223);
			XmlNodeList.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeList>.NativeClassPtr, 100664224);
			XmlNodeList.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeList>.NativeClassPtr, 100664225);
			XmlNodeList.NativeMethodInfoPtr_PrivateDisposeNodeList_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeList>.NativeClassPtr, 100664226);
			XmlNodeList.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeList>.NativeClassPtr, 100664227);
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00020EDC File Offset: 0x0001F0DC
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNodeList.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00020F24 File Offset: 0x0001F124
		[CallerCount(0)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNodeList.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00020F70 File Offset: 0x0001F170
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 16379, RefRangeEnd = 16382, XrefRangeStart = 16379, XrefRangeEnd = 16379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeList.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PrivateDisposeNodeList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNodeList.NativeMethodInfoPtr_PrivateDisposeNodeList_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00020FE0 File Offset: 0x0001F1E0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeList.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00003ED9 File Offset: 0x000020D9
		public XmlNodeList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_PrivateDisposeNodeList_Protected_Virtual_New_Void_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
