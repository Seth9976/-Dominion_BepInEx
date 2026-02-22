using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SubsystemsImplementation
{
	// Token: 0x0200000D RID: 13
	public class SubsystemDescriptorWithProvider : Object
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000035E0 File Offset: 0x000017E0
		// Note: this type is marked as 'beforefieldinit'.
		static SubsystemDescriptorWithProvider()
		{
			Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine.SubsystemsImplementation", "SubsystemDescriptorWithProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr);
			SubsystemDescriptorWithProvider.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr, "<id>k__BackingField");
			SubsystemDescriptorWithProvider.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr, 100663322);
			SubsystemDescriptorWithProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr, 100663323);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000364C File Offset: 0x0000184C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000243E File Offset: 0x0000063E
		public unsafe virtual string id
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorWithProvider.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this._id_k__BackingField = value;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003684 File Offset: 0x00001884
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubsystemDescriptorWithProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemDescriptorWithProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptorWithProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002416 File Offset: 0x00000616
		public SubsystemDescriptorWithProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000036C0 File Offset: 0x000018C0
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000241F File Offset: 0x0000061F
		public unsafe string _id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubsystemDescriptorWithProvider.NativeFieldInfoPtr__id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubsystemDescriptorWithProvider.NativeFieldInfoPtr__id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002447 File Offset: 0x00000647
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002454 File Offset: 0x00000654
		public Type providerType
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002461 File Offset: 0x00000661
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000246E File Offset: 0x0000066E
		public Type subsystemTypeOverride
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000247B File Offset: 0x0000067B
		public ISubsystem UnityEngine.ISubsystemDescriptor.Create()
		{
			return this.CreateImpl();
		}

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
