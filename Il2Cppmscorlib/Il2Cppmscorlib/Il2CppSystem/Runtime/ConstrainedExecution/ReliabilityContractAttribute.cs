using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ConstrainedExecution
{
	// Token: 0x02000412 RID: 1042
	public sealed class ReliabilityContractAttribute : Attribute
	{
		// Token: 0x06004173 RID: 16755 RVA: 0x0012E72C File Offset: 0x0012C92C
		// Note: this type is marked as 'beforefieldinit'.
		static ReliabilityContractAttribute()
		{
			Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ConstrainedExecution", "ReliabilityContractAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr);
			ReliabilityContractAttribute.NativeFieldInfoPtr__consistency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, "_consistency");
			ReliabilityContractAttribute.NativeFieldInfoPtr__cer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, "_cer");
			ReliabilityContractAttribute.NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, 100672824);
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x0012E798 File Offset: 0x0012C998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356082, XrefRangeEnd = 356083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref consistencyGuarantee;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReliabilityContractAttribute.NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x00018E44 File Offset: 0x00017044
		public ReliabilityContractAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06004176 RID: 16758 RVA: 0x0012E7F0 File Offset: 0x0012C9F0
		// (set) Token: 0x06004177 RID: 16759 RVA: 0x00018E4D File Offset: 0x0001704D
		public unsafe Consistency _consistency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__consistency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__consistency)) = value;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06004178 RID: 16760 RVA: 0x0012E818 File Offset: 0x0012CA18
		// (set) Token: 0x06004179 RID: 16761 RVA: 0x00018E68 File Offset: 0x00017068
		public unsafe Cer _cer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__cer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__cer)) = value;
			}
		}

		// Token: 0x04003573 RID: 13683
		private static readonly IntPtr NativeFieldInfoPtr__consistency;

		// Token: 0x04003574 RID: 13684
		private static readonly IntPtr NativeFieldInfoPtr__cer;

		// Token: 0x04003575 RID: 13685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0;
	}
}
