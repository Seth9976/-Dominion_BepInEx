using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000413 RID: 1043
	public sealed class TupleElementNamesAttribute : Attribute
	{
		// Token: 0x0600417A RID: 16762 RVA: 0x0012E840 File Offset: 0x0012CA40
		// Note: this type is marked as 'beforefieldinit'.
		static TupleElementNamesAttribute()
		{
			Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TupleElementNamesAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr);
			TupleElementNamesAttribute.NativeFieldInfoPtr__transformNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr, "_transformNames");
			TupleElementNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr, 100672825);
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x0012E898 File Offset: 0x0012CA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356083, XrefRangeEnd = 356084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TupleElementNamesAttribute(Il2CppStringArray transformNames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformNames);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleElementNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x00018E83 File Offset: 0x00017083
		public TupleElementNamesAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x0600417D RID: 16765 RVA: 0x0012E8E4 File Offset: 0x0012CAE4
		// (set) Token: 0x0600417E RID: 16766 RVA: 0x00018E8C File Offset: 0x0001708C
		public unsafe Il2CppStringArray _transformNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleElementNamesAttribute.NativeFieldInfoPtr__transformNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleElementNamesAttribute.NativeFieldInfoPtr__transformNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003576 RID: 13686
		private static readonly IntPtr NativeFieldInfoPtr__transformNames;

		// Token: 0x04003577 RID: 13687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;
	}
}
