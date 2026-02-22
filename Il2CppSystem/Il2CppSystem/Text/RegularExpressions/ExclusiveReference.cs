using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000049 RID: 73
	public sealed class ExclusiveReference : Object
	{
		// Token: 0x06000456 RID: 1110 RVA: 0x00021AC4 File Offset: 0x0001FCC4
		// Note: this type is marked as 'beforefieldinit'.
		static ExclusiveReference()
		{
			Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "ExclusiveReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr);
			ExclusiveReference.NativeFieldInfoPtr__ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, "_ref");
			ExclusiveReference.NativeFieldInfoPtr__obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, "_obj");
			ExclusiveReference.NativeFieldInfoPtr__locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, "_locked");
			ExclusiveReference.NativeMethodInfoPtr_Get_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, 100663947);
			ExclusiveReference.NativeMethodInfoPtr_Release_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, 100663948);
			ExclusiveReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, 100663949);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00021B6C File Offset: 0x0001FD6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37567, RefRangeEnd = 37568, XrefRangeStart = 37566, XrefRangeEnd = 37567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveReference.NativeMethodInfoPtr_Get_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00021BAC File Offset: 0x0001FDAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37571, RefRangeEnd = 37572, XrefRangeStart = 37568, XrefRangeEnd = 37571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveReference.NativeMethodInfoPtr_Release_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00021BF0 File Offset: 0x0001FDF0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExclusiveReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00003945 File Offset: 0x00001B45
		public ExclusiveReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00021C2C File Offset: 0x0001FE2C
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x0000394E File Offset: 0x00001B4E
		public unsafe RegexRunner _ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__ref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexRunner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__ref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00021C5C File Offset: 0x0001FE5C
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x0000396D File Offset: 0x00001B6D
		public unsafe Object _obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__obj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__obj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00021C8C File Offset: 0x0001FE8C
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x0000398C File Offset: 0x00001B8C
		public unsafe int _locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__locked)) = value;
			}
		}

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr__ref;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr__obj;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr__locked;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Object_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_Release_Internal_Void_Object_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
