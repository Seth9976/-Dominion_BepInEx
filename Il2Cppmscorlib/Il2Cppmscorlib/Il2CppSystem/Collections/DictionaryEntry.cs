using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200046B RID: 1131
	[Serializable]
	public sealed class DictionaryEntry : ValueType
	{
		// Token: 0x060043A5 RID: 17317 RVA: 0x001357D8 File Offset: 0x001339D8
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryEntry()
		{
			Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "DictionaryEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr);
			DictionaryEntry.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, "_key");
			DictionaryEntry.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, "_value");
			DictionaryEntry.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, 100673077);
			DictionaryEntry.NativeMethodInfoPtr_get_Key_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, 100673078);
			DictionaryEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr, 100673079);
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x0013586C File Offset: 0x00133A6C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 52612, RefRangeEnd = 52647, XrefRangeStart = 52612, XrefRangeEnd = 52647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictionaryEntry(Object key, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryEntry.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x060043A7 RID: 17319 RVA: 0x001358D0 File Offset: 0x00133AD0
		public unsafe Object Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryEntry.NativeMethodInfoPtr_get_Key_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x060043A8 RID: 17320 RVA: 0x00135914 File Offset: 0x00133B14
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryEntry.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x0001A011 File Offset: 0x00018211
		public DictionaryEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x0001A01A File Offset: 0x0001821A
		public DictionaryEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryEntry>.NativeClassPtr))
		{
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x060043AB RID: 17323 RVA: 0x00135958 File Offset: 0x00133B58
		// (set) Token: 0x060043AC RID: 17324 RVA: 0x0001A02C File Offset: 0x0001822C
		public unsafe Object _key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x060043AD RID: 17325 RVA: 0x00135988 File Offset: 0x00133B88
		// (set) Token: 0x060043AE RID: 17326 RVA: 0x0001A04B File Offset: 0x0001824B
		public unsafe Object _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryEntry.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003725 RID: 14117
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x04003726 RID: 14118
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04003727 RID: 14119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;

		// Token: 0x04003728 RID: 14120
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_Object_0;

		// Token: 0x04003729 RID: 14121
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;
	}
}
