using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003C RID: 60
	public class XmlNodeChangedEventArgs : EventArgs
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x00020A90 File Offset: 0x0001EC90
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeChangedEventArgs()
		{
			Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNodeChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr);
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "action");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "node");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "oldParent");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_newParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "newParent");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "oldValue");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_newValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "newValue");
			XmlNodeChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, 100664219);
			XmlNodeChangedEventArgs.NativeMethodInfoPtr_get_Action_Public_get_XmlNodeChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, 100664220);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00020B60 File Offset: 0x0001ED60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16378, RefRangeEnd = 16379, XrefRangeStart = 16374, XrefRangeEnd = 16378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldParent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00020C04 File Offset: 0x0001EE04
		public unsafe XmlNodeChangedAction Action
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeChangedEventArgs.NativeMethodInfoPtr_get_Action_Public_get_XmlNodeChangedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00003DEA File Offset: 0x00001FEA
		public XmlNodeChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00020C40 File Offset: 0x0001EE40
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00003DF3 File Offset: 0x00001FF3
		public unsafe XmlNodeChangedAction action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_action);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_action)) = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00020C68 File Offset: 0x0001EE68
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x00003E0E File Offset: 0x0000200E
		public unsafe XmlNode node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00020C98 File Offset: 0x0001EE98
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00003E2D File Offset: 0x0000202D
		public unsafe XmlNode oldParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00003E4C File Offset: 0x0000204C
		public unsafe XmlNode newParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00020CF8 File Offset: 0x0001EEF8
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x00003E6B File Offset: 0x0000206B
		public unsafe string oldValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00020D20 File Offset: 0x0001EF20
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x00003E8A File Offset: 0x0000208A
		public unsafe string newValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr_node;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_oldParent;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_newParent;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_oldValue;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr_newValue;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_get_Action_Public_get_XmlNodeChangedAction_0;
	}
}
