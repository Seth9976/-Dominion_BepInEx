using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x02000114 RID: 276
	public class MovedFromAttribute : Attribute
	{
		// Token: 0x06001677 RID: 5751 RVA: 0x00055778 File Offset: 0x00053978
		// Note: this type is marked as 'beforefieldinit'.
		static MovedFromAttribute()
		{
			Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting.APIUpdating", "MovedFromAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr);
			MovedFromAttribute.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, "data");
			MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, 100664973);
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x000557D0 File Offset: 0x000539D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81235, XrefRangeEnd = 81236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MovedFromAttribute(string sourceNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0000CB02 File Offset: 0x0000AD02
		public MovedFromAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x0005581C File Offset: 0x00053A1C
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x0000CB0B File Offset: 0x0000AD0B
		public MovedFromAttributeData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttribute.NativeFieldInfoPtr_data);
				return new MovedFromAttributeData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttribute.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x0000CB39 File Offset: 0x0000AD39
		public bool AffectsAPIUpdater
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x0000CB46 File Offset: 0x0000AD46
		public bool IsInDifferentAssembly
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
