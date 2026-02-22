using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200011F RID: 287
	public class RaycastMask : MonoBehaviour
	{
		// Token: 0x06002099 RID: 8345 RVA: 0x0007D370 File Offset: 0x0007B570
		// Note: this type is marked as 'beforefieldinit'.
		static RaycastMask()
		{
			Il2CppClassPointerStore<RaycastMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI.Extensions", "RaycastMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastMask>.NativeClassPtr);
			RaycastMask.NativeFieldInfoPtr__image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastMask>.NativeClassPtr, "_image");
			RaycastMask.NativeFieldInfoPtr__sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastMask>.NativeClassPtr, "_sprite");
			RaycastMask.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastMask>.NativeClassPtr, 100665954);
			RaycastMask.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastMask>.NativeClassPtr, 100665955);
			RaycastMask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastMask>.NativeClassPtr, 100665956);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0007D404 File Offset: 0x0007B604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257704, XrefRangeEnd = 257707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastMask.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0007D438 File Offset: 0x0007B638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257707, XrefRangeEnd = 257769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastMask.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0007D494 File Offset: 0x0007B694
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaycastMask()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RaycastMask>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastMask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000143B9 File Offset: 0x000125B9
		public RaycastMask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x0007D4D0 File Offset: 0x0007B6D0
		// (set) Token: 0x0600209F RID: 8351 RVA: 0x000143C2 File Offset: 0x000125C2
		public unsafe Image _image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastMask.NativeFieldInfoPtr__image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastMask.NativeFieldInfoPtr__image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0007D500 File Offset: 0x0007B700
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x000143E1 File Offset: 0x000125E1
		public unsafe Sprite _sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastMask.NativeFieldInfoPtr__sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastMask.NativeFieldInfoPtr__sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeFieldInfoPtr__image;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeFieldInfoPtr__sprite;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
