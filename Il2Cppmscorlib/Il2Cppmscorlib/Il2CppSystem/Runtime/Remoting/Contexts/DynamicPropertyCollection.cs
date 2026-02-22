using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003B5 RID: 949
	public class DynamicPropertyCollection : Object
	{
		// Token: 0x06003DBC RID: 15804 RVA: 0x00121508 File Offset: 0x0011F708
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicPropertyCollection()
		{
			Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "DynamicPropertyCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr);
			DynamicPropertyCollection.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, "_properties");
			DynamicPropertyCollection.NativeMethodInfoPtr_get_HasProperties_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672379);
			DynamicPropertyCollection.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Boolean_IDynamicProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672380);
			DynamicPropertyCollection.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672381);
			DynamicPropertyCollection.NativeMethodInfoPtr_NotifyMessage_Public_Void_Boolean_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672382);
			DynamicPropertyCollection.NativeMethodInfoPtr_FindProperty_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672383);
			DynamicPropertyCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, 100672384);
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06003DBD RID: 15805 RVA: 0x001215C4 File Offset: 0x0011F7C4
		public unsafe bool HasProperties
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 352739, RefRangeEnd = 352752, XrefRangeStart = 352739, XrefRangeEnd = 352739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_get_HasProperties_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00121600 File Offset: 0x0011F800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352772, RefRangeEnd = 352773, XrefRangeStart = 352752, XrefRangeEnd = 352772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RegisterDynamicProperty(IDynamicProperty prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_RegisterDynamicProperty_Public_Boolean_IDynamicProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00121650 File Offset: 0x0011F850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352777, RefRangeEnd = 352778, XrefRangeStart = 352773, XrefRangeEnd = 352777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UnregisterDynamicProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x001216A0 File Offset: 0x0011F8A0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 352797, RefRangeEnd = 352806, XrefRangeStart = 352778, XrefRangeEnd = 352797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyMessage(bool start, IMessage msg, bool client_site, bool async)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref client_site;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_NotifyMessage_Public_Void_Boolean_IMessage_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x0012170C File Offset: 0x0011F90C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352813, RefRangeEnd = 352815, XrefRangeStart = 352806, XrefRangeEnd = 352813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr_FindProperty_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x0012175C File Offset: 0x0011F95C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 352820, RefRangeEnd = 352826, XrefRangeStart = 352815, XrefRangeEnd = 352820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicPropertyCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x000173DA File Offset: 0x000155DA
		public DynamicPropertyCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06003DC4 RID: 15812 RVA: 0x00121798 File Offset: 0x0011F998
		// (set) Token: 0x06003DC5 RID: 15813 RVA: 0x000173E3 File Offset: 0x000155E3
		public unsafe ArrayList _properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.NativeFieldInfoPtr__properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.NativeFieldInfoPtr__properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003311 RID: 13073
		private static readonly IntPtr NativeFieldInfoPtr__properties;

		// Token: 0x04003312 RID: 13074
		private static readonly IntPtr NativeMethodInfoPtr_get_HasProperties_Public_get_Boolean_0;

		// Token: 0x04003313 RID: 13075
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDynamicProperty_Public_Boolean_IDynamicProperty_0;

		// Token: 0x04003314 RID: 13076
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDynamicProperty_Public_Boolean_String_0;

		// Token: 0x04003315 RID: 13077
		private static readonly IntPtr NativeMethodInfoPtr_NotifyMessage_Public_Void_Boolean_IMessage_Boolean_Boolean_0;

		// Token: 0x04003316 RID: 13078
		private static readonly IntPtr NativeMethodInfoPtr_FindProperty_Private_Int32_String_0;

		// Token: 0x04003317 RID: 13079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200062C RID: 1580
		public class DynamicPropertyReg : Object
		{
			// Token: 0x06005442 RID: 21570 RVA: 0x00175118 File Offset: 0x00173318
			// Note: this type is marked as 'beforefieldinit'.
			static DynamicPropertyReg()
			{
				Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicPropertyCollection>.NativeClassPtr, "DynamicPropertyReg");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr);
				DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr, "Property");
				DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Sink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr, "Sink");
				DynamicPropertyCollection.DynamicPropertyReg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr, 100672385);
			}

			// Token: 0x06005443 RID: 21571 RVA: 0x00175180 File Offset: 0x00173380
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicPropertyReg()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicPropertyCollection.DynamicPropertyReg>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicPropertyCollection.DynamicPropertyReg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005444 RID: 21572 RVA: 0x000207D7 File Offset: 0x0001E9D7
			public DynamicPropertyReg(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001593 RID: 5523
			// (get) Token: 0x06005445 RID: 21573 RVA: 0x001751BC File Offset: 0x001733BC
			// (set) Token: 0x06005446 RID: 21574 RVA: 0x000207E0 File Offset: 0x0001E9E0
			public unsafe IDynamicProperty Property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Property);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDynamicProperty>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001594 RID: 5524
			// (get) Token: 0x06005447 RID: 21575 RVA: 0x001751EC File Offset: 0x001733EC
			// (set) Token: 0x06005448 RID: 21576 RVA: 0x000207FF File Offset: 0x0001E9FF
			public unsafe IDynamicMessageSink Sink
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Sink);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDynamicMessageSink>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicPropertyCollection.DynamicPropertyReg.NativeFieldInfoPtr_Sink), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043E0 RID: 17376
			private static readonly IntPtr NativeFieldInfoPtr_Property;

			// Token: 0x040043E1 RID: 17377
			private static readonly IntPtr NativeFieldInfoPtr_Sink;

			// Token: 0x040043E2 RID: 17378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
