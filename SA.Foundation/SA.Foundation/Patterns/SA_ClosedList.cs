using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Foundation.Events;

namespace SA.Foundation.Patterns
{
	// Token: 0x02000021 RID: 33
	public class SA_ClosedList<T> : Object
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00007868 File Offset: 0x00005A68
		// Note: this type is marked as 'beforefieldinit'.
		static SA_ClosedList()
		{
			Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Patterns", "SA_ClosedList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr);
			SA_ClosedList<T>.NativeFieldInfoPtr_m_onItemAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, "m_onItemAdded");
			SA_ClosedList<T>.NativeFieldInfoPtr_s_onItemRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, "s_onItemRemoved");
			SA_ClosedList<T>.NativeFieldInfoPtr_m_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, "m_items");
			SA_ClosedList<T>.NativeMethodInfoPtr_get_Items_Public_Virtual_Final_New_get_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, 100663461);
			SA_ClosedList<T>.NativeMethodInfoPtr_get_ItemsList_Public_get_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, 100663462);
			SA_ClosedList<T>.NativeMethodInfoPtr_set_ItemsList_Public_set_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, 100663463);
			SA_ClosedList<T>.NativeMethodInfoPtr_SetList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, 100663464);
			SA_ClosedList<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, 100663465);
			SA_ClosedList<T>.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, 100663466);
			SA_ClosedList<T>.NativeMethodInfoPtr_Remove_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, 100663467);
			SA_ClosedList<T>.NativeMethodInfoPtr_get_OnItemAdded_Public_Virtual_Final_New_get_SA_iEvent_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, 100663468);
			SA_ClosedList<T>.NativeMethodInfoPtr_get_OnItemRemoved_Public_Virtual_Final_New_get_SA_iEvent_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, 100663469);
			SA_ClosedList<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr, 100663470);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000079D8 File Offset: 0x00005BD8
		public unsafe virtual IEnumerable<T> Items
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ClosedList<T>.NativeMethodInfoPtr_get_Items_Public_Virtual_Final_New_get_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00007A18 File Offset: 0x00005C18
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00007A58 File Offset: 0x00005C58
		public unsafe List<T> ItemsList
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ClosedList<T>.NativeMethodInfoPtr_get_ItemsList_Public_get_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99589, XrefRangeEnd = 99598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ClosedList<T>.NativeMethodInfoPtr_set_ItemsList_Public_set_Void_List_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007A9C File Offset: 0x00005C9C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ClosedList<T>.NativeMethodInfoPtr_SetList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99598, XrefRangeEnd = 99607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ClosedList<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007B04 File Offset: 0x00005D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99607, XrefRangeEnd = 99608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SA_ClosedList<T>.NativeMethodInfoPtr_Add_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00007B7C File Offset: 0x00005D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99608, XrefRangeEnd = 99609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SA_ClosedList<T>.NativeMethodInfoPtr_Remove_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00007BF4 File Offset: 0x00005DF4
		public unsafe virtual SA_iEvent<T> OnItemAdded
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ClosedList<T>.NativeMethodInfoPtr_get_OnItemAdded_Public_Virtual_Final_New_get_SA_iEvent_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iEvent<T>>(intPtr3) : null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00007C34 File Offset: 0x00005E34
		public unsafe virtual SA_iEvent<T> OnItemRemoved
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ClosedList<T>.NativeMethodInfoPtr_get_OnItemRemoved_Public_Virtual_Final_New_get_SA_iEvent_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_iEvent<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007C74 File Offset: 0x00005E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99609, XrefRangeEnd = 99616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_ClosedList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ClosedList<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ClosedList<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000237A File Offset: 0x0000057A
		public SA_ClosedList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00007CB0 File Offset: 0x00005EB0
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002383 File Offset: 0x00000583
		public unsafe SA_Event<T> m_onItemAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ClosedList<T>.NativeFieldInfoPtr_m_onItemAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Event<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ClosedList<T>.NativeFieldInfoPtr_m_onItemAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00007CE0 File Offset: 0x00005EE0
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000023A2 File Offset: 0x000005A2
		public unsafe SA_Event<T> s_onItemRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ClosedList<T>.NativeFieldInfoPtr_s_onItemRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Event<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ClosedList<T>.NativeFieldInfoPtr_s_onItemRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00007D10 File Offset: 0x00005F10
		// (set) Token: 0x0600010C RID: 268 RVA: 0x000023C1 File Offset: 0x000005C1
		public unsafe List<T> m_items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ClosedList<T>.NativeFieldInfoPtr_m_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_ClosedList<T>.NativeFieldInfoPtr_m_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_m_onItemAdded;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_s_onItemRemoved;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_m_items;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_Virtual_Final_New_get_IEnumerable_1_T_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemsList_Public_get_List_1_T_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemsList_Public_set_Void_List_1_T_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_SetList_Public_Void_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_T_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_get_OnItemAdded_Public_Virtual_Final_New_get_SA_iEvent_1_T_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_get_OnItemRemoved_Public_Virtual_Final_New_get_SA_iEvent_1_T_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
