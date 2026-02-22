using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.IO
{
	// Token: 0x020001FF RID: 511
	public class Iterator<TSource> : Object
	{
		// Token: 0x060020AD RID: 8365 RVA: 0x000B54B0 File Offset: 0x000B36B0
		// Note: this type is marked as 'beforefieldinit'.
		static Iterator()
		{
			Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Iterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr);
			Iterator<TSource>.NativeFieldInfoPtr_threadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, "threadId");
			Iterator<TSource>.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, "state");
			Iterator<TSource>.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, "current");
			Iterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, 100668733);
			Iterator<TSource>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, 100668734);
			Iterator<TSource>.NativeMethodInfoPtr_Clone_Protected_Abstract_Virtual_New_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, 100668735);
			Iterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, 100668736);
			Iterator<TSource>.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, 100668737);
			Iterator<TSource>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, 100668738);
			Iterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, 100668739);
			Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, 100668740);
			Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, 100668741);
			Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr, 100668742);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x000B5620 File Offset: 0x000B3820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Iterator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Iterator<TSource>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Iterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x000B565C File Offset: 0x000B385C
		public unsafe virtual TSource Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Iterator<TSource>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x000B5698 File Offset: 0x000B3898
		[CallerCount(0)]
		public unsafe virtual Iterator<TSource> Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Iterator<TSource>.NativeMethodInfoPtr_Clone_Protected_Abstract_Virtual_New_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Iterator<TSource>>(intPtr3) : null;
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x000B56E4 File Offset: 0x000B38E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320700, XrefRangeEnd = 320705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Iterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x000B5718 File Offset: 0x000B3918
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Iterator<TSource>.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x000B5764 File Offset: 0x000B3964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<TSource> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Iterator<TSource>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x000B57A4 File Offset: 0x000B39A4
		[CallerCount(0)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Iterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000B57EC File Offset: 0x000B39EC
		public unsafe virtual Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x000B582C File Offset: 0x000B3A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320705, XrefRangeEnd = 320716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x000B586C File Offset: 0x000B3A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320716, XrefRangeEnd = 320721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0000B090 File Offset: 0x00009290
		public Iterator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x000B58A0 File Offset: 0x000B3AA0
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x0000B099 File Offset: 0x00009299
		public unsafe int threadId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Iterator<TSource>.NativeFieldInfoPtr_threadId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Iterator<TSource>.NativeFieldInfoPtr_threadId)) = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x000B58C8 File Offset: 0x000B3AC8
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x0000B0B4 File Offset: 0x000092B4
		public unsafe int state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Iterator<TSource>.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Iterator<TSource>.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x000B58F0 File Offset: 0x000B3AF0
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x000B5918 File Offset: 0x000B3B18
		public unsafe TSource current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Iterator<TSource>.NativeFieldInfoPtr_current);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Iterator<TSource>.NativeFieldInfoPtr_current);
				Type typeFromHandle = typeof(TSource);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeFieldInfoPtr_threadId;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Protected_Abstract_Virtual_New_Iterator_1_TSource_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
	}
}
