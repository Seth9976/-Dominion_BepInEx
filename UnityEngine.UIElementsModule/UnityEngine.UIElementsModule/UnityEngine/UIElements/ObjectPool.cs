using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000014 RID: 20
	public class ObjectPool<T> : Object where T : new()
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00010410 File Offset: 0x0000E610
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPool()
		{
			Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr);
			ObjectPool<T>.NativeFieldInfoPtr_m_Stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_Stack");
			ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_MaxSize");
			ObjectPool<T>.NativeMethodInfoPtr_get_maxSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100663395);
			ObjectPool<T>.NativeMethodInfoPtr_set_maxSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100663396);
			ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100663397);
			ObjectPool<T>.NativeMethodInfoPtr_Size_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100663398);
			ObjectPool<T>.NativeMethodInfoPtr_Get_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100663399);
			ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100663400);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0001051C File Offset: 0x0000E71C
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00010558 File Offset: 0x0000E758
		public unsafe int maxSize
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 88838, RefRangeEnd = 88870, XrefRangeStart = 88838, XrefRangeEnd = 88870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_get_maxSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91874, XrefRangeEnd = 91879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_set_maxSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00010598 File Offset: 0x0000E798
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91882, RefRangeEnd = 91884, XrefRangeStart = 91879, XrefRangeEnd = 91882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPool(int maxSize = 100)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000105E0 File Offset: 0x0000E7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91884, XrefRangeEnd = 91885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Size()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Size_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0001061C File Offset: 0x0000E81C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 91885, RefRangeEnd = 91890, XrefRangeStart = 91885, XrefRangeEnd = 91885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Get_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00010658 File Offset: 0x0000E858
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 91896, RefRangeEnd = 91900, XrefRangeStart = 91890, XrefRangeEnd = 91896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(T element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = element;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002910 File Offset: 0x00000B10
		public ObjectPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000106D0 File Offset: 0x0000E8D0
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002919 File Offset: 0x00000B19
		public unsafe Stack<T> m_Stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_Stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_Stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00010700 File Offset: 0x0000E900
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002938 File Offset: 0x00000B38
		public unsafe int m_MaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize)) = value;
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002953 File Offset: 0x00000B53
		public void Clear()
		{
			this.m_Stack.Clear();
		}

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_m_Stack;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSize;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSize_Public_get_Int32_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_set_maxSize_Public_set_Void_Int32_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_Size_Public_Int32_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_T_0;
	}
}
