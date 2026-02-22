using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000020 RID: 32
	public sealed class SavePersistentViewData : MulticastDelegate
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x00011FE8 File Offset: 0x000101E8
		// Note: this type is marked as 'beforefieldinit'.
		static SavePersistentViewData()
		{
			Il2CppClassPointerStore<SavePersistentViewData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "SavePersistentViewData");
			SavePersistentViewData.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePersistentViewData>.NativeClassPtr, 100663445);
			SavePersistentViewData.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePersistentViewData>.NativeClassPtr, 100663446);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00012038 File Offset: 0x00010238
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SavePersistentViewData(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SavePersistentViewData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePersistentViewData.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00012094 File Offset: 0x00010294
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavePersistentViewData.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002E38 File Offset: 0x00001038
		public SavePersistentViewData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002E41 File Offset: 0x00001041
		public static implicit operator SavePersistentViewData(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<SavePersistentViewData>(A_0);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002E49 File Offset: 0x00001049
		public static SavePersistentViewData operator +(SavePersistentViewData A_0, SavePersistentViewData A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SavePersistentViewData>();
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002E57 File Offset: 0x00001057
		public static SavePersistentViewData operator -(SavePersistentViewData A_0, SavePersistentViewData A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SavePersistentViewData>();
			}
			return delegate2;
		}

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}
