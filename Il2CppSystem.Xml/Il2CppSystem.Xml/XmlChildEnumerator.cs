using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002A RID: 42
	public sealed class XmlChildEnumerator : Object
	{
		// Token: 0x06000378 RID: 888 RVA: 0x000173E8 File Offset: 0x000155E8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlChildEnumerator()
		{
			Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlChildEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr);
			XmlChildEnumerator.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, "container");
			XmlChildEnumerator.NativeFieldInfoPtr_child = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, "child");
			XmlChildEnumerator.NativeFieldInfoPtr_isFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, "isFirst");
			XmlChildEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100663890);
			XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100663891);
			XmlChildEnumerator.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100663892);
			XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100663893);
			XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100663894);
			XmlChildEnumerator.NativeMethodInfoPtr_get_Current_Internal_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr, 100663895);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000174CC File Offset: 0x000156CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14925, RefRangeEnd = 14926, XrefRangeStart = 14924, XrefRangeEnd = 14925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlChildEnumerator(XmlNode container)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlChildEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00017518 File Offset: 0x00015718
		[CallerCount(0)]
		public unsafe bool System_Collections_IEnumerator_MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00017554 File Offset: 0x00015754
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00017590 File Offset: 0x00015790
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600037D RID: 893 RVA: 0x000175C4 File Offset: 0x000157C4
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00017604 File Offset: 0x00015804
		public unsafe XmlNode Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildEnumerator.NativeMethodInfoPtr_get_Current_Internal_get_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00003286 File Offset: 0x00001486
		public XmlChildEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00017644 File Offset: 0x00015844
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0000328F File Offset: 0x0000148F
		public unsafe XmlNode container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00017674 File Offset: 0x00015874
		// (set) Token: 0x06000383 RID: 899 RVA: 0x000032AE File Offset: 0x000014AE
		public unsafe XmlNode child
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_child);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_child), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000384 RID: 900 RVA: 0x000176A4 File Offset: 0x000158A4
		// (set) Token: 0x06000385 RID: 901 RVA: 0x000032CD File Offset: 0x000014CD
		public unsafe bool isFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_isFirst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildEnumerator.NativeFieldInfoPtr_isFirst)) = value;
			}
		}

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr_child;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr_isFirst;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Internal_Boolean_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_XmlNode_0;
	}
}
