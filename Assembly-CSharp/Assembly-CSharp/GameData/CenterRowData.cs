using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x0200012D RID: 301
	public sealed class CenterRowData : ValueType
	{
		// Token: 0x0600217A RID: 8570 RVA: 0x0007F820 File Offset: 0x0007DA20
		// Note: this type is marked as 'beforefieldinit'.
		static CenterRowData()
		{
			Il2CppClassPointerStore<CenterRowData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "CenterRowData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr);
			CenterRowData.NativeFieldInfoPtr_centerrow_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr, "centerrow_instance_id");
			CenterRowData.NativeFieldInfoPtr_is_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr, "is_active");
			CenterRowData.NativeFieldInfoPtr_top_card_instance_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr, "top_card_instance_count");
			CenterRowData.NativeFieldInfoPtr_top_card_instance_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr, "top_card_instance_list");
			CenterRowData.NativeFieldInfoPtr_underneath_card_instance_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr, "underneath_card_instance_count");
			CenterRowData.NativeFieldInfoPtr_underneath_card_instance_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr, "underneath_card_instance_list");
			CenterRowData.NativeFieldInfoPtr_rat_card_instance_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr, "rat_card_instance_count");
			CenterRowData.NativeFieldInfoPtr_rat_card_instance_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr, "rat_card_instance_list");
			CenterRowData.NativeFieldInfoPtr_treasure_card_instance_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr, "treasure_card_instance_count");
			CenterRowData.NativeFieldInfoPtr_treasure_card_instance_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr, "treasure_card_instance_list");
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00014CAF File Offset: 0x00012EAF
		public CenterRowData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00014CB8 File Offset: 0x00012EB8
		public CenterRowData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CenterRowData>.NativeClassPtr))
		{
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x0007F918 File Offset: 0x0007DB18
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x00014CCA File Offset: 0x00012ECA
		public unsafe short centerrow_instance_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_centerrow_instance_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_centerrow_instance_id)) = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x0007F940 File Offset: 0x0007DB40
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x00014CE5 File Offset: 0x00012EE5
		public unsafe short is_active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_is_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_is_active)) = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x0007F968 File Offset: 0x0007DB68
		// (set) Token: 0x06002182 RID: 8578 RVA: 0x00014D00 File Offset: 0x00012F00
		public unsafe short top_card_instance_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_top_card_instance_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_top_card_instance_count)) = value;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x0007F990 File Offset: 0x0007DB90
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x00014D1B File Offset: 0x00012F1B
		public unsafe Il2CppStructArray<short> top_card_instance_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_top_card_instance_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_top_card_instance_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x0007F9C0 File Offset: 0x0007DBC0
		// (set) Token: 0x06002186 RID: 8582 RVA: 0x00014D3A File Offset: 0x00012F3A
		public unsafe short underneath_card_instance_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_underneath_card_instance_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_underneath_card_instance_count)) = value;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x0007F9E8 File Offset: 0x0007DBE8
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x00014D55 File Offset: 0x00012F55
		public unsafe Il2CppStructArray<short> underneath_card_instance_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_underneath_card_instance_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_underneath_card_instance_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x0007FA18 File Offset: 0x0007DC18
		// (set) Token: 0x0600218A RID: 8586 RVA: 0x00014D74 File Offset: 0x00012F74
		public unsafe short rat_card_instance_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_rat_card_instance_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_rat_card_instance_count)) = value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x0007FA40 File Offset: 0x0007DC40
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x00014D8F File Offset: 0x00012F8F
		public unsafe Il2CppStructArray<short> rat_card_instance_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_rat_card_instance_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_rat_card_instance_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x0007FA70 File Offset: 0x0007DC70
		// (set) Token: 0x0600218E RID: 8590 RVA: 0x00014DAE File Offset: 0x00012FAE
		public unsafe short treasure_card_instance_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_treasure_card_instance_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_treasure_card_instance_count)) = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x0007FA98 File Offset: 0x0007DC98
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x00014DC9 File Offset: 0x00012FC9
		public unsafe Il2CppStructArray<short> treasure_card_instance_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_treasure_card_instance_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CenterRowData.NativeFieldInfoPtr_treasure_card_instance_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeFieldInfoPtr_centerrow_instance_id;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeFieldInfoPtr_is_active;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeFieldInfoPtr_top_card_instance_count;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeFieldInfoPtr_top_card_instance_list;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr_underneath_card_instance_count;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeFieldInfoPtr_underneath_card_instance_list;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeFieldInfoPtr_rat_card_instance_count;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeFieldInfoPtr_rat_card_instance_list;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeFieldInfoPtr_treasure_card_instance_count;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeFieldInfoPtr_treasure_card_instance_list;
	}
}
