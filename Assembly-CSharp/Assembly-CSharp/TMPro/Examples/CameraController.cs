using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000102 RID: 258
	public class CameraController : MonoBehaviour
	{
		// Token: 0x06001E97 RID: 7831 RVA: 0x00077BE8 File Offset: 0x00075DE8
		// Note: this type is marked as 'beforefieldinit'.
		static CameraController()
		{
			Il2CppClassPointerStore<CameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "CameraController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraController>.NativeClassPtr);
			CameraController.NativeFieldInfoPtr_cameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "cameraTransform");
			CameraController.NativeFieldInfoPtr_dummyTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "dummyTarget");
			CameraController.NativeFieldInfoPtr_CameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "CameraTarget");
			CameraController.NativeFieldInfoPtr_FollowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "FollowDistance");
			CameraController.NativeFieldInfoPtr_MaxFollowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "MaxFollowDistance");
			CameraController.NativeFieldInfoPtr_MinFollowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "MinFollowDistance");
			CameraController.NativeFieldInfoPtr_ElevationAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "ElevationAngle");
			CameraController.NativeFieldInfoPtr_MaxElevationAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "MaxElevationAngle");
			CameraController.NativeFieldInfoPtr_MinElevationAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "MinElevationAngle");
			CameraController.NativeFieldInfoPtr_OrbitalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "OrbitalAngle");
			CameraController.NativeFieldInfoPtr_CameraMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "CameraMode");
			CameraController.NativeFieldInfoPtr_MovementSmoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "MovementSmoothing");
			CameraController.NativeFieldInfoPtr_RotationSmoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "RotationSmoothing");
			CameraController.NativeFieldInfoPtr_previousSmoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "previousSmoothing");
			CameraController.NativeFieldInfoPtr_MovementSmoothingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "MovementSmoothingValue");
			CameraController.NativeFieldInfoPtr_RotationSmoothingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "RotationSmoothingValue");
			CameraController.NativeFieldInfoPtr_MoveSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "MoveSensitivity");
			CameraController.NativeFieldInfoPtr_currentVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "currentVelocity");
			CameraController.NativeFieldInfoPtr_desiredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "desiredPosition");
			CameraController.NativeFieldInfoPtr_mouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "mouseX");
			CameraController.NativeFieldInfoPtr_mouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "mouseY");
			CameraController.NativeFieldInfoPtr_moveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "moveVector");
			CameraController.NativeFieldInfoPtr_mouseWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "mouseWheel");
			CameraController.NativeFieldInfoPtr_event_SmoothingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "event_SmoothingValue");
			CameraController.NativeFieldInfoPtr_event_FollowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraController>.NativeClassPtr, "event_FollowDistance");
			CameraController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100665818);
			CameraController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100665819);
			CameraController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100665820);
			CameraController.NativeMethodInfoPtr_GetPlayerInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100665821);
			CameraController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraController>.NativeClassPtr, 100665822);
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00077E70 File Offset: 0x00076070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255841, XrefRangeEnd = 255847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00077EA4 File Offset: 0x000760A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255847, XrefRangeEnd = 255858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00077ED8 File Offset: 0x000760D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255858, XrefRangeEnd = 255878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00077F0C File Offset: 0x0007610C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255949, RefRangeEnd = 255950, XrefRangeStart = 255878, XrefRangeEnd = 255949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPlayerInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraController.NativeMethodInfoPtr_GetPlayerInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00077F40 File Offset: 0x00076140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255950, XrefRangeEnd = 255952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00013121 File Offset: 0x00011321
		public CameraController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x00077F7C File Offset: 0x0007617C
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x0001312A File Offset: 0x0001132A
		public unsafe Transform cameraTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_cameraTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_cameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x00077FAC File Offset: 0x000761AC
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x00013149 File Offset: 0x00011349
		public unsafe Transform dummyTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_dummyTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_dummyTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x00077FDC File Offset: 0x000761DC
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00013168 File Offset: 0x00011368
		public unsafe Transform CameraTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_CameraTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_CameraTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x0007800C File Offset: 0x0007620C
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00013187 File Offset: 0x00011387
		public unsafe float FollowDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_FollowDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_FollowDistance)) = value;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x00078034 File Offset: 0x00076234
		// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x000131A2 File Offset: 0x000113A2
		public unsafe float MaxFollowDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MaxFollowDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MaxFollowDistance)) = value;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x0007805C File Offset: 0x0007625C
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x000131BD File Offset: 0x000113BD
		public unsafe float MinFollowDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MinFollowDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MinFollowDistance)) = value;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00078084 File Offset: 0x00076284
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x000131D8 File Offset: 0x000113D8
		public unsafe float ElevationAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_ElevationAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_ElevationAngle)) = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x000780AC File Offset: 0x000762AC
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x000131F3 File Offset: 0x000113F3
		public unsafe float MaxElevationAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MaxElevationAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MaxElevationAngle)) = value;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x000780D4 File Offset: 0x000762D4
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x0001320E File Offset: 0x0001140E
		public unsafe float MinElevationAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MinElevationAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MinElevationAngle)) = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x000780FC File Offset: 0x000762FC
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x00013229 File Offset: 0x00011429
		public unsafe float OrbitalAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_OrbitalAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_OrbitalAngle)) = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00078124 File Offset: 0x00076324
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x00013244 File Offset: 0x00011444
		public unsafe CameraController.CameraModes CameraMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_CameraMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_CameraMode)) = value;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0007814C File Offset: 0x0007634C
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0001325F File Offset: 0x0001145F
		public unsafe bool MovementSmoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MovementSmoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MovementSmoothing)) = value;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00078174 File Offset: 0x00076374
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x0001327A File Offset: 0x0001147A
		public unsafe bool RotationSmoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_RotationSmoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_RotationSmoothing)) = value;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x0007819C File Offset: 0x0007639C
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x00013295 File Offset: 0x00011495
		public unsafe bool previousSmoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_previousSmoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_previousSmoothing)) = value;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x000781C4 File Offset: 0x000763C4
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x000132B0 File Offset: 0x000114B0
		public unsafe float MovementSmoothingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MovementSmoothingValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MovementSmoothingValue)) = value;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x000781EC File Offset: 0x000763EC
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x000132CB File Offset: 0x000114CB
		public unsafe float RotationSmoothingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_RotationSmoothingValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_RotationSmoothingValue)) = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00078214 File Offset: 0x00076414
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x000132E6 File Offset: 0x000114E6
		public unsafe float MoveSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MoveSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_MoveSensitivity)) = value;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x0007823C File Offset: 0x0007643C
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x00013301 File Offset: 0x00011501
		public unsafe Vector3 currentVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_currentVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_currentVelocity)) = value;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00078264 File Offset: 0x00076464
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x0001331C File Offset: 0x0001151C
		public unsafe Vector3 desiredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_desiredPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_desiredPosition)) = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x0007828C File Offset: 0x0007648C
		// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x00013337 File Offset: 0x00011537
		public unsafe float mouseX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_mouseX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_mouseX)) = value;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x000782B4 File Offset: 0x000764B4
		// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x00013352 File Offset: 0x00011552
		public unsafe float mouseY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_mouseY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_mouseY)) = value;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x000782DC File Offset: 0x000764DC
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x0001336D File Offset: 0x0001156D
		public unsafe Vector3 moveVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_moveVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_moveVector)) = value;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00078304 File Offset: 0x00076504
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00013388 File Offset: 0x00011588
		public unsafe float mouseWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_mouseWheel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraController.NativeFieldInfoPtr_mouseWheel)) = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x0007832C File Offset: 0x0007652C
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x000133A3 File Offset: 0x000115A3
		public unsafe static string event_SmoothingValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraController.NativeFieldInfoPtr_event_SmoothingValue, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraController.NativeFieldInfoPtr_event_SmoothingValue, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x0007834C File Offset: 0x0007654C
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x000133B5 File Offset: 0x000115B5
		public unsafe static string event_FollowDistance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraController.NativeFieldInfoPtr_event_FollowDistance, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraController.NativeFieldInfoPtr_event_FollowDistance, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeFieldInfoPtr_cameraTransform;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeFieldInfoPtr_dummyTarget;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeFieldInfoPtr_CameraTarget;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeFieldInfoPtr_FollowDistance;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeFieldInfoPtr_MaxFollowDistance;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeFieldInfoPtr_MinFollowDistance;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeFieldInfoPtr_ElevationAngle;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeFieldInfoPtr_MaxElevationAngle;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeFieldInfoPtr_MinElevationAngle;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeFieldInfoPtr_OrbitalAngle;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeFieldInfoPtr_CameraMode;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeFieldInfoPtr_MovementSmoothing;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeFieldInfoPtr_RotationSmoothing;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeFieldInfoPtr_previousSmoothing;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeFieldInfoPtr_MovementSmoothingValue;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeFieldInfoPtr_RotationSmoothingValue;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeFieldInfoPtr_MoveSensitivity;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeFieldInfoPtr_currentVelocity;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeFieldInfoPtr_desiredPosition;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeFieldInfoPtr_mouseX;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeFieldInfoPtr_mouseY;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeFieldInfoPtr_moveVector;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeFieldInfoPtr_mouseWheel;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeFieldInfoPtr_event_SmoothingValue;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeFieldInfoPtr_event_FollowDistance;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerInput_Private_Void_0;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000224 RID: 548
		public enum CameraModes
		{
			// Token: 0x04001D0A RID: 7434
			Follow,
			// Token: 0x04001D0B RID: 7435
			Isometric,
			// Token: 0x04001D0C RID: 7436
			Free
		}
	}
}
