using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public class SubsystemDescriptor : Object
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002BD4 File Offset: 0x00000DD4
		// Note: this type is marked as 'beforefieldinit'.
		static SubsystemDescriptor()
		{
			Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "SubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr);
			SubsystemDescriptor.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr, "<id>k__BackingField");
			SubsystemDescriptor.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr, 100663306);
			SubsystemDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr, 100663307);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002C40 File Offset: 0x00000E40
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000220A File Offset: 0x0000040A
		public unsafe virtual string id
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptor.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this._id_k__BackingField = value;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002C78 File Offset: 0x00000E78
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021E2 File Offset: 0x000003E2
		public SubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002CB4 File Offset: 0x00000EB4
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000021EB File Offset: 0x000003EB
		public unsafe string _id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubsystemDescriptor.NativeFieldInfoPtr__id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubsystemDescriptor.NativeFieldInfoPtr__id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002213 File Offset: 0x00000413
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002220 File Offset: 0x00000420
		public Type subsystemImplementationType
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

		// Token: 0x06000036 RID: 54 RVA: 0x0000222D File Offset: 0x0000042D
		public ISubsystem UnityEngine.ISubsystemDescriptor.Create()
		{
			return this.CreateImpl();
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
