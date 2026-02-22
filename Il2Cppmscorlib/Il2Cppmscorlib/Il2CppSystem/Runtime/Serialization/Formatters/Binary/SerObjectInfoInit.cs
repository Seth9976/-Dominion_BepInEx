using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037B RID: 891
	public sealed class SerObjectInfoInit : Object
	{
		// Token: 0x0600390F RID: 14607 RVA: 0x00110EAC File Offset: 0x0010F0AC
		// Note: this type is marked as 'beforefieldinit'.
		static SerObjectInfoInit()
		{
			Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerObjectInfoInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr);
			SerObjectInfoInit.NativeFieldInfoPtr_seenBeforeTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "seenBeforeTable");
			SerObjectInfoInit.NativeFieldInfoPtr_objectInfoIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "objectInfoIdCount");
			SerObjectInfoInit.NativeFieldInfoPtr_oiPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, "oiPool");
			SerObjectInfoInit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr, 100671882);
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x00110F2C File Offset: 0x0010F12C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346451, RefRangeEnd = 346453, XrefRangeStart = 346437, XrefRangeEnd = 346451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerObjectInfoInit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerObjectInfoInit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerObjectInfoInit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x00014FC6 File Offset: 0x000131C6
		public SerObjectInfoInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06003912 RID: 14610 RVA: 0x00110F68 File Offset: 0x0010F168
		// (set) Token: 0x06003913 RID: 14611 RVA: 0x00014FCF File Offset: 0x000131CF
		public unsafe Hashtable seenBeforeTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_seenBeforeTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_seenBeforeTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06003914 RID: 14612 RVA: 0x00110F98 File Offset: 0x0010F198
		// (set) Token: 0x06003915 RID: 14613 RVA: 0x00014FEE File Offset: 0x000131EE
		public unsafe int objectInfoIdCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_objectInfoIdCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_objectInfoIdCount)) = value;
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06003916 RID: 14614 RVA: 0x00110FC0 File Offset: 0x0010F1C0
		// (set) Token: 0x06003917 RID: 14615 RVA: 0x00015009 File Offset: 0x00013209
		public unsafe SerStack oiPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_oiPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerObjectInfoInit.NativeFieldInfoPtr_oiPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FFC RID: 12284
		private static readonly IntPtr NativeFieldInfoPtr_seenBeforeTable;

		// Token: 0x04002FFD RID: 12285
		private static readonly IntPtr NativeFieldInfoPtr_objectInfoIdCount;

		// Token: 0x04002FFE RID: 12286
		private static readonly IntPtr NativeFieldInfoPtr_oiPool;

		// Token: 0x04002FFF RID: 12287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
