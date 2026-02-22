using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000153 RID: 339
	public sealed class TurnNumber : ValueType
	{
		// Token: 0x06002220 RID: 8736 RVA: 0x00080FAC File Offset: 0x0007F1AC
		// Note: this type is marked as 'beforefieldinit'.
		static TurnNumber()
		{
			Il2CppClassPointerStore<TurnNumber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "TurnNumber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TurnNumber>.NativeClassPtr);
			TurnNumber.NativeFieldInfoPtr_roundNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnNumber>.NativeClassPtr, "roundNumber");
			TurnNumber.NativeFieldInfoPtr_playerFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnNumber>.NativeClassPtr, "playerFaction");
			TurnNumber.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnNumber>.NativeClassPtr, "playerName");
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000155B4 File Offset: 0x000137B4
		public TurnNumber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x000155BD File Offset: 0x000137BD
		public TurnNumber()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TurnNumber>.NativeClassPtr))
		{
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x00081018 File Offset: 0x0007F218
		// (set) Token: 0x06002224 RID: 8740 RVA: 0x000155CF File Offset: 0x000137CF
		public unsafe int roundNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TurnNumber.NativeFieldInfoPtr_roundNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TurnNumber.NativeFieldInfoPtr_roundNumber)) = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x00081040 File Offset: 0x0007F240
		// (set) Token: 0x06002226 RID: 8742 RVA: 0x000155EA File Offset: 0x000137EA
		public unsafe int playerFaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TurnNumber.NativeFieldInfoPtr_playerFaction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TurnNumber.NativeFieldInfoPtr_playerFaction)) = value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x00081068 File Offset: 0x0007F268
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x00015605 File Offset: 0x00013805
		public unsafe string playerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TurnNumber.NativeFieldInfoPtr_playerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TurnNumber.NativeFieldInfoPtr_playerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeFieldInfoPtr_roundNumber;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeFieldInfoPtr_playerFaction;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeFieldInfoPtr_playerName;
	}
}
