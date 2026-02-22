using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000332 RID: 818
	[Serializable]
	public class ObjectIDGenerator : Object
	{
		// Token: 0x06003499 RID: 13465 RVA: 0x00101558 File Offset: 0x000FF758
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectIDGenerator()
		{
			Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectIDGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr);
			ObjectIDGenerator.NativeFieldInfoPtr_m_currentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_currentCount");
			ObjectIDGenerator.NativeFieldInfoPtr_m_currentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_currentSize");
			ObjectIDGenerator.NativeFieldInfoPtr_m_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_ids");
			ObjectIDGenerator.NativeFieldInfoPtr_m_objs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "m_objs");
			ObjectIDGenerator.NativeFieldInfoPtr_sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, "sizes");
			ObjectIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671451);
			ObjectIDGenerator.NativeMethodInfoPtr_FindElement_Private_Int32_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671452);
			ObjectIDGenerator.NativeMethodInfoPtr_GetId_Public_Virtual_New_Int64_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671453);
			ObjectIDGenerator.NativeMethodInfoPtr_HasId_Public_Virtual_New_Int64_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671454);
			ObjectIDGenerator.NativeMethodInfoPtr_Rehash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr, 100671455);
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00101650 File Offset: 0x000FF850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342814, XrefRangeEnd = 342824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectIDGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectIDGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x0010168C File Offset: 0x000FF88C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 342826, RefRangeEnd = 342829, XrefRangeStart = 342824, XrefRangeEnd = 342826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindElement(Object obj, out bool found)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &found;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectIDGenerator.NativeMethodInfoPtr_FindElement_Private_Int32_Object_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x001016E8 File Offset: 0x000FF8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342829, XrefRangeEnd = 342833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long GetId(Object obj, out bool firstTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &firstTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectIDGenerator.NativeMethodInfoPtr_GetId_Public_Virtual_New_Int64_Object_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x00101750 File Offset: 0x000FF950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342833, XrefRangeEnd = 342834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long HasId(Object obj, out bool firstTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &firstTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectIDGenerator.NativeMethodInfoPtr_HasId_Public_Virtual_New_Int64_Object_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x001017B8 File Offset: 0x000FF9B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342854, RefRangeEnd = 342855, XrefRangeStart = 342834, XrefRangeEnd = 342854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rehash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectIDGenerator.NativeMethodInfoPtr_Rehash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00012C4C File Offset: 0x00010E4C
		public ObjectIDGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x001017EC File Offset: 0x000FF9EC
		// (set) Token: 0x060034A1 RID: 13473 RVA: 0x00012C55 File Offset: 0x00010E55
		public unsafe int m_currentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentCount)) = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060034A2 RID: 13474 RVA: 0x00101814 File Offset: 0x000FFA14
		// (set) Token: 0x060034A3 RID: 13475 RVA: 0x00012C70 File Offset: 0x00010E70
		public unsafe int m_currentSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_currentSize)) = value;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x0010183C File Offset: 0x000FFA3C
		// (set) Token: 0x060034A5 RID: 13477 RVA: 0x00012C8B File Offset: 0x00010E8B
		public unsafe Il2CppStructArray<long> m_ids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_ids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x0010186C File Offset: 0x000FFA6C
		// (set) Token: 0x060034A7 RID: 13479 RVA: 0x00012CAA File Offset: 0x00010EAA
		public unsafe Il2CppReferenceArray<Object> m_objs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_objs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectIDGenerator.NativeFieldInfoPtr_m_objs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x0010189C File Offset: 0x000FFA9C
		// (set) Token: 0x060034A9 RID: 13481 RVA: 0x00012CC9 File Offset: 0x00010EC9
		public unsafe static Il2CppStructArray<int> sizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectIDGenerator.NativeFieldInfoPtr_sizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectIDGenerator.NativeFieldInfoPtr_sizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C96 RID: 11414
		private static readonly IntPtr NativeFieldInfoPtr_m_currentCount;

		// Token: 0x04002C97 RID: 11415
		private static readonly IntPtr NativeFieldInfoPtr_m_currentSize;

		// Token: 0x04002C98 RID: 11416
		private static readonly IntPtr NativeFieldInfoPtr_m_ids;

		// Token: 0x04002C99 RID: 11417
		private static readonly IntPtr NativeFieldInfoPtr_m_objs;

		// Token: 0x04002C9A RID: 11418
		private static readonly IntPtr NativeFieldInfoPtr_sizes;

		// Token: 0x04002C9B RID: 11419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C9C RID: 11420
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Private_Int32_Object_byref_Boolean_0;

		// Token: 0x04002C9D RID: 11421
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Public_Virtual_New_Int64_Object_byref_Boolean_0;

		// Token: 0x04002C9E RID: 11422
		private static readonly IntPtr NativeMethodInfoPtr_HasId_Public_Virtual_New_Int64_Object_byref_Boolean_0;

		// Token: 0x04002C9F RID: 11423
		private static readonly IntPtr NativeMethodInfoPtr_Rehash_Private_Void_0;
	}
}
