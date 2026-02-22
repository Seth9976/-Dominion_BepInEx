using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000F5 RID: 245
	[DefaultMember("Item")]
	public class XmlSchemaObjectCollection : CollectionBase
	{
		// Token: 0x06000ED9 RID: 3801 RVA: 0x00045B40 File Offset: 0x00043D40
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaObjectCollection()
		{
			Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaObjectCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr);
			XmlSchemaObjectCollection.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, "parent");
			XmlSchemaObjectCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100665456);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_Add_Public_Int32_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100665457);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_OnInsert_Protected_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100665458);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_OnSet_Protected_Virtual_Void_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100665459);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_OnClear_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100665460);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_OnRemove_Protected_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100665461);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00045BFC File Offset: 0x00043DFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8104, RefRangeEnd = 8106, XrefRangeStart = 8104, XrefRangeEnd = 8106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObjectCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00045C38 File Offset: 0x00043E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24788, XrefRangeEnd = 24794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(XmlSchemaObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectCollection.NativeMethodInfoPtr_Add_Public_Int32_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00045C88 File Offset: 0x00043E88
		[CallerCount(0)]
		public unsafe override void OnInsert(int index, Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObjectCollection.NativeMethodInfoPtr_OnInsert_Protected_Virtual_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00045CE4 File Offset: 0x00043EE4
		[CallerCount(0)]
		public unsafe override void OnSet(int index, Object oldValue, Object newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObjectCollection.NativeMethodInfoPtr_OnSet_Protected_Virtual_Void_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00045D54 File Offset: 0x00043F54
		[CallerCount(0)]
		public unsafe override void OnClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObjectCollection.NativeMethodInfoPtr_OnClear_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00045D90 File Offset: 0x00043F90
		[CallerCount(0)]
		public unsafe override void OnRemove(int index, Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObjectCollection.NativeMethodInfoPtr_OnRemove_Protected_Virtual_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00007047 File Offset: 0x00005247
		public XmlSchemaObjectCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00045DEC File Offset: 0x00043FEC
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00007050 File Offset: 0x00005250
		public unsafe XmlSchemaObject parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectCollection.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectCollection.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlSchemaObject_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_OnInsert_Protected_Virtual_Void_Int32_Object_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_OnSet_Protected_Virtual_Void_Int32_Object_Object_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_OnClear_Protected_Virtual_Void_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_OnRemove_Protected_Virtual_Void_Int32_Object_0;
	}
}
