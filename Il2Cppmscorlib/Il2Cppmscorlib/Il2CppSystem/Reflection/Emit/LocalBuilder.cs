using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x020001EC RID: 492
	public sealed class LocalBuilder : LocalVariableInfo
	{
		// Token: 0x06001F9D RID: 8093 RVA: 0x000B05E0 File Offset: 0x000AE7E0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalBuilder()
		{
			Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "LocalBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr);
			LocalBuilder.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "name");
			LocalBuilder.NativeFieldInfoPtr_ilgen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "ilgen");
			LocalBuilder.NativeFieldInfoPtr_startOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "startOffset");
			LocalBuilder.NativeFieldInfoPtr_endOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalBuilder>.NativeClassPtr, "endOffset");
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x0000ABDE File Offset: 0x00008DDE
		public LocalBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x000B0660 File Offset: 0x000AE860
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0000ABE7 File Offset: 0x00008DE7
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x000B0688 File Offset: 0x000AE888
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x0000AC06 File Offset: 0x00008E06
		public unsafe ILGenerator ilgen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_ilgen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_ilgen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x000B06B8 File Offset: 0x000AE8B8
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0000AC25 File Offset: 0x00008E25
		public unsafe int startOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_startOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_startOffset)) = value;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000B06E0 File Offset: 0x000AE8E0
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x0000AC40 File Offset: 0x00008E40
		public unsafe int endOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_endOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalBuilder.NativeFieldInfoPtr_endOffset)) = value;
			}
		}

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeFieldInfoPtr_ilgen;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeFieldInfoPtr_startOffset;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeFieldInfoPtr_endOffset;
	}
}
