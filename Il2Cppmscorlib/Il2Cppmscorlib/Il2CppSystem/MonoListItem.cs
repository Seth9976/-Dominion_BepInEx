using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000122 RID: 290
	public sealed class MonoListItem : Object
	{
		// Token: 0x060014B5 RID: 5301 RVA: 0x000807F4 File Offset: 0x0007E9F4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoListItem()
		{
			Il2CppClassPointerStore<MonoListItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoListItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr);
			MonoListItem.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr, "next");
			MonoListItem.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr, "data");
			MonoListItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr, 100666833);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00080860 File Offset: 0x0007EA60
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoListItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoListItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0000739F File Offset: 0x0000559F
		public MonoListItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0008089C File Offset: 0x0007EA9C
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x000073A8 File Offset: 0x000055A8
		public unsafe MonoListItem next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoListItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x000808CC File Offset: 0x0007EACC
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x000073C7 File Offset: 0x000055C7
		public unsafe Object data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
